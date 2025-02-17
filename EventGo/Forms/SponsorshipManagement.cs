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
using System.Windows.Forms;

namespace EventGo.Forms
{
    public partial class SponsorshipManagement : Form
    {
        private DataContext _context = new DataContext();
        BindingSource bindingSource = new BindingSource();
        private string operation, dgClick;
        private int selectedSponsorId, selectedEventId;
        public SponsorshipManagement()
        {
            InitializeComponent();
        }

        private async void loadComboBoxData()
        {
            using (var _context = new DataContext())
            {
                var events = await _context.Events.ToListAsync();
                cbEventList.DataSource = events;
                cbEventList.DisplayMember = "Title";
                cbEventList.ValueMember = "Id";
            }
        }

        private void loadSponsors(int eventId)
        {
            var sponsors = _context.Sponsors
                .Where(e => e.EventId == eventId && e.deleted_at == null) // Cek deleted_at
                .Select(e => new SponsorDTO
                {
                    Id = e.Id,
                    Brand = e.Brand,
                    Pic_name = e.Pic_name,
                    Pic_number = e.Pic_number,
                    Budget = e.Budget,
                    EventName = e.Event.Title
                })
                .ToList();

            bindingSource.DataSource = sponsors;
            dgvSponsors.DataSource = bindingSource;
            calculateTotalBudget(eventId);
        }



        private void disableField()
        {
            tbSponsorName.Enabled = false;
            tbPicName.Enabled = false;
            tbPicNumber.Enabled = false;
            numAmount.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableField()
        {
            tbSponsorName.Enabled = true;
            tbPicName.Enabled = true;
            tbPicNumber.Enabled = true;
            numAmount.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }
        private void clearField()
        {
            tbSponsorName.Text = "";
            tbPicName.Text = "";
            tbPicNumber.Text = "";
            numAmount.Value = 0;
        }
        private void SponsorshipManagement_Load(object sender, EventArgs e)
        {
            loadComboBoxData();
            disableField();
        }

        private void cbEventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEventList.SelectedItem is Event selectedEvent)
            {
                selectedEventId = selectedEvent.Id;
                loadSponsors(selectedEventId);
            }
        }

        private void btnAddSponsor_Click(object sender, EventArgs e)
        {
            btnAddSponsor.Enabled = false;
            btnEditSponsor.Enabled = false;
            btnDeleteSponsor.Enabled = false;
            btnRestoreSponsor.Enabled = false;
            enableField();
            operation = "Create";
        }

        private async void actionCreate()
        {
            using (var _context = new DataContext())
            {
                var sponsor = new Sponsor
                {
                    Brand = tbSponsorName.Text,
                    Pic_name = tbPicName.Text,
                    Pic_number = tbPicNumber.Text,
                    Budget = numAmount.Value.ToString(),
                    EventId = (int)cbEventList.SelectedValue,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                _context.Sponsors.Add(sponsor);
                await _context.SaveChangesAsync();
                MessageBox.Show("Sponsor berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearField();
                disableField();
                loadSponsors(selectedEventId);
                btnAddSponsor.Enabled = true;
                btnEditSponsor.Enabled = true;
                btnDeleteSponsor.Enabled = true;
            }
        }

        private void btnEditSponsor_Click(object sender, EventArgs e)
        {
            if (selectedEventId > 0)
            {
                enableField();
                btnEditSponsor.Enabled = false;
                btnDeleteSponsor.Enabled = false;
                btnAddSponsor.Enabled = false;

                operation = "Edit";
            }
            else
            {
                MessageBox.Show("Please select one row to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSponsor_Click(object sender, EventArgs e)
        {
            var sponsor = _context.Sponsors.Find(selectedSponsorId);
            if (sponsor != null)
            {
                var confirm = MessageBox.Show("Are you sure want to delete this sponsor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    sponsor.deleted_at = DateTime.Now;
                    _context.SaveChanges();
                    MessageBox.Show("Sponsor berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadSponsors(selectedEventId);
                    calculateTotalBudget(selectedEventId);
                }
            }
            else
            {
                MessageBox.Show("Please select one row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            disableField();
            btnAddSponsor.Enabled = true;
            btnEditSponsor.Enabled = true;
            btnDeleteSponsor.Enabled = true;
        }

        private void btnRestoreSponsor_Click(object sender, EventArgs e)
        {

        }

        private void dgvSponsors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek jika e.RowIndex valid
            if (e.RowIndex >= 0 && e.RowIndex < bindingSource.Count)
            {
                var selectedSponsor = (SponsorDTO)bindingSource[e.RowIndex];
                selectedSponsorId = selectedSponsor.Id;
                tbSponsorName.Text = selectedSponsor.Brand;
                tbPicName.Text = selectedSponsor.Pic_name;
                tbPicNumber.Text = selectedSponsor.Pic_number;
                numAmount.Value = decimal.Parse(selectedSponsor.Budget);
                dgClick = "Clicked";
                disableField();
                btnEditSponsor.Enabled = true;
                btnDeleteSponsor.Enabled = true;
            }
        }

        private async void actionEdit()
        {
            using(var _context = new DataContext())
            {
                var sponsor = await _context.Sponsors.FindAsync(selectedSponsorId);
                sponsor.Brand = tbSponsorName.Text;
                sponsor.Pic_name = tbPicName.Text;
                sponsor.Pic_number = tbPicNumber.Text;
                sponsor.Budget = numAmount.Value.ToString();
                sponsor.updated_at = DateTime.Now;
                await _context.SaveChangesAsync();
                MessageBox.Show("Sponsor berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableField();
                loadSponsors(selectedEventId);
                btnAddSponsor.Enabled = true;
                btnEditSponsor.Enabled = true;
                btnDeleteSponsor.Enabled = true;
            }
        }

        private void calculateTotalBudget(int eventId)
        {
            var totalBudget = _context.Sponsors
                .Where(s => s.EventId == eventId && s.deleted_at == null) // Tambahkan filter deleted_at
                .AsEnumerable() // Ambil data ke dalam memory dulu
                .Sum(s => decimal.TryParse(s.Budget, out var value) ? value : 0); // Konversi aman

            lblTotalAmount.Text = $"Total Budget: {totalBudget:N0}"; // Format angka dengan pemisah ribuan
        }
    }
}
