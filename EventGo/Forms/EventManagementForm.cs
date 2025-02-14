using EventGo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EventGo.Forms
{
    public partial class EventManagementForm : Form
    {
        private string operation;
        BindingSource bindingSource = new BindingSource();
        private string? dgClick;
        private int? selectedEventId;

        public EventManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadViewData();
            disableField();
            autoCompleteByTitle();
        }

        private async void LoadViewData()
        {
            using (var _context = new DataContext())
            {
                var data = await _context.Events.ToListAsync();
                bindingSource.DataSource = data;
                dgvEvent.DataSource = bindingSource;
            }
        }

        private void disableField()
        {
            tbEventId.Enabled = false;
            tbEventTitle.Enabled = false;
            cbStatus.Enabled = false;
            rtbDescription.Enabled = false;
            dtOpen.Enabled = false;
            dtClosed.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            enableField();
            clearField();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            operation = "Create";
        }

        private async void actionCreate()
        {
            using (var _context = new DataContext())
            {
                if (tbEventTitle.Text.Length == 0 || cbStatus.Text.Length == 0 || rtbDescription.Text.Length == 0 || dtOpen.Text.Length == 0 || dtClosed.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the input field");
                }
                else
                {
                    Event newEvent = new Event();
                    newEvent.Title = tbEventTitle.Text.ToString();
                    newEvent.Status = cbStatus.Text.ToString();
                    newEvent.Description = rtbDescription.Text.ToString();
                    newEvent.Open_date = dtOpen.Value;
                    newEvent.Closed_date = dtClosed.Value;

                    _context.Events.AddAsync(newEvent);
                    await _context.SaveChangesAsync();
                    LoadViewData();
                    disableField();
                    clearField();
                }
            }
        }

        private void enableField()
        {
            tbEventTitle.Enabled = true;
            cbStatus.Enabled = true;
            rtbDescription.Enabled = true;
            dtOpen.Enabled = true;
            dtClosed.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void clearField()
        {
            tbEventTitle.Text = "";
            cbStatus.Text = "";
            rtbDescription.Text = "";
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
                    ActionDelete();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            disableField();
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCreate.Enabled = true;
        }

        private void dgvEvent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvEvent.Rows[index];
            var selectedEvent = (Event)bindingSource.List[index];
            selectedEventId = selectedEvent.Id;

            tbEventId.Text = selectedEvent.Id.ToString();
            tbEventTitle.Text = selectedEvent.Title;
            cbStatus.Text = selectedEvent.Status;
            rtbDescription.Text = selectedEvent.Description;
            dtOpen.Value = selectedEvent.Open_date;
            dtClosed.Value = selectedEvent.Closed_date;

            dgClick = "Clicked";
            disableField();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("please select one row to edit");
            }
            else
            {
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                enableField();

                operation = "Edit";
            }
        }

        private async void actionEdit()
        {
            using (var _context = new DataContext())
            {
                if (selectedEventId != null)
                {
                    Event editTargetEvent = await _context.Events.FindAsync(selectedEventId);
                    if (editTargetEvent != null)
                    {
                        editTargetEvent.Title = tbEventTitle.Text;
                        editTargetEvent.Status = cbStatus.Text;
                        editTargetEvent.Description = rtbDescription.Text;
                        editTargetEvent.Open_date = dtOpen.Value;
                        editTargetEvent.Closed_date = dtClosed.Value;

                        _context.Events.Update(editTargetEvent);
                        await _context.SaveChangesAsync();
                        LoadViewData();
                        dgvEvent.Refresh();
                        MessageBox.Show("Edit berhasil");
                        clearField();
                        btnCreate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Event Not Found");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please Select one row");
            }
            else
            {
                disableField();
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;

                operation = "Delete";
            }
        }

        private async void ActionDelete()
        {
            using (var _context = new DataContext())
            {
                if (selectedEventId != null)
                {
                    var deleteTargetEvent = await _context.Events.Where(e => e.Id == selectedEventId).FirstOrDefaultAsync();

                    if (MessageBox.Show("Are you sure you want to delete this data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        _context.Events.Remove(deleteTargetEvent);
                        await _context.SaveChangesAsync();
                        selectedEventId = null;
                        LoadViewData();
                        dgvEvent.Refresh();
                        MessageBox.Show("Successfully delete event");
                        clearField();
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                        btnCreate.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Event Data not found");
                }
            }
        }

        private void autoCompleteByTitle()
        {
            using (var _context = new DataContext())
            {
                var title = _context.Events.Select(e => e.Title).ToArray();
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                autoCompleteStringCollection.AddRange(title);
                tbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
            }
        }

        private async void showByTitle(string title)
        {
            using (var _context = new DataContext())
            {
                _context.Events.Load();
                List<Event>? events = await _context.Events.Where(e => e.Title.Contains(title)).ToListAsync();
                bindingSource.DataSource = events.ToList();
                dgvEvent.Refresh();
            }
        }

        private async void showByStatus(string status)
        {
            using (var _context = new DataContext())
            {
                _context.Events.Load();
                List<Event>? events = await _context.Events.Where(e => e.Status.Contains(status)).ToListAsync();
                bindingSource.DataSource = events.ToList();
                dgvEvent.Refresh();
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            showByTitle(tbSearch.Text.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            showByStatus(cbFilter.Text.ToString());
        }
    }
}
