using EventGo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace EventGo.Forms
{
    public partial class TicketManagementForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private string operation;
        private string? dgClick;
        private int? selectedTicketId;
        public TicketManagementForm()
        {
            InitializeComponent();
        }

        private async void loadViewData()
        {
            using (var _context = new DataContext())
            {
                var data = await _context.vw_TicketDetails.ToListAsync();
                bindingSource.DataSource = data;
                dgvTicket.DataSource = bindingSource;
            }
        }

        private void TicketManagementForm_Load(object sender, EventArgs e)
        {
            loadViewData();
            loadComboboxData();
            disableField();
        }

        private void disableField()
        {
            tbTicketId.Enabled = false;
            numPrice.Enabled = false;
            numStock.Enabled = false;
            cbEventName.Enabled = false;
            cbCategory.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableField()
        {
            numPrice.Enabled = true;
            numStock.Enabled = true;
            cbEventName.Enabled = true;
            cbCategory.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void clearField()
        {
            numPrice.Value = 0;
            numStock.Value = 0;
            cbEventName.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            enableField();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            operation = "Create";
        }

        private async void actionCreate()
        {
            using (var _context = new DataContext())
            {
                Ticket newTicket = new Ticket()
                {
                    Price = (int)numPrice.Value,
                    Total_stock = (int)numStock.Value,
                    EventId = (int)cbEventName.SelectedValue,
                    CategoryId = (int)cbCategory.SelectedValue
                };
                _context.Tickets.Add(newTicket);
                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
                clearField();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please Select one row to edit");
            }
            else
            {
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                operation = "Edit";
                enableField();
            }

        }

        private async void actionEdit()
        {
            using(var _context = new DataContext())
            {
                if(selectedTicketId != null)
                {
                    Ticket editTargetTicket = await _context.Tickets.FindAsync(selectedTicketId);
                    if(editTargetTicket != null)
                    {
                        editTargetTicket.Price = (int)numPrice.Value;
                        editTargetTicket.Total_stock = (int)numStock.Value;
                        editTargetTicket.EventId = (int)cbEventName.SelectedValue;
                        editTargetTicket.CategoryId = (int)cbCategory.SelectedValue;

                        _context.Tickets.Update(editTargetTicket);
                        await _context.SaveChangesAsync();
                        loadViewData();
                        dgvTicket.Refresh();
                        disableField();
                        clearField();
                        btnCreate.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;

                        MessageBox.Show("Edit Ticket Berhasil");
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please select one row to delete");
            }
            else
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

                operation = "Delete";
            }
        }

        private async void actionDelete()
        {
            using(var _context = new DataContext())
            {
                if (selectedTicketId != null)
                {
                    var deleteTicketTarget = await _context.Tickets.Where(e => e.Id == selectedTicketId).FirstOrDefaultAsync();

                    if (MessageBox.Show("Are you sure you want to delete this data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        _context.Remove(deleteTicketTarget);
                        await _context.SaveChangesAsync();
                        selectedTicketId = null;
                        loadViewData();
                        dgvTicket.Refresh();
                        MessageBox.Show("Berhasil menghapus data");
                        clearField();
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                        btnCreate.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            disableField();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnCreate.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Create":
                    actionCreate();
                    break;
                case "Edit":
                    actionEdit();
                    break;
                case "Delete":
                    actionDelete();
                    break;
            }
        }

        private async void loadComboboxData()
        {
            using (var _context = new DataContext())
            {
                cbEventName.DataSource = await _context.Events.ToListAsync();
                cbEventName.DisplayMember = "Title";
                cbEventName.ValueMember = "Id";

                cbCategory.DataSource = await _context.Categories.ToListAsync();
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
            }
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvTicket.Rows[index];
            var selectedTicket = (VW_TicketDetails)bindingSource.List[index];
            selectedTicketId = selectedTicket.TicketID;
            tbTicketId.Text = selectedTicket.TicketID.ToString();
            numPrice.Value = selectedTicket.Price;
            numStock.Value = selectedTicket.Total_stock;
            cbEventName.Text = selectedTicket.EventName;
            cbCategory.Text = selectedTicket.CategoryName;
            dgClick = "Clicked";
            disableField();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
