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
    public partial class ManagementForm : Form
    {
        private string operation;
        BindingSource bindingSource = new BindingSource();
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoadViewData();
            disableField();
            lblNewCategory.Visible = false;
            tbNewCategory.Visible = false;
        }

        private void LoadViewData()
        {
            using (var _context = new DataContext())
            {
                var data = _context.ViewManagements.ToList();
                bindingSource.DataSource = data;
                dgManagement.DataSource = bindingSource;

            }
        }

        private void disableField()
        {
            tbTicketId.Enabled = false;
            numStock.Enabled = false;
            cbCategory.Enabled = false;
            tbEventId.Enabled = false;
            tbEventTitle.Enabled = false;
            cbStatus.Enabled = false;
            rtbDescription.Enabled = false;
            dtOpen.Enabled = false;
            dtClosed.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableWhenCreate()
        {
            numStock.Enabled = true;
            cbCategory.Enabled = true;
            tbEventTitle.Enabled = true;
            cbStatus.Enabled = true;
            rtbDescription.Enabled = true;
            dtOpen.Enabled = true;
            dtClosed.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            enableWhenCreate();

            operation = "Create";
        }

        private async void actionCreateWithTicket()
        {
            if (string.IsNullOrWhiteSpace(tbEventTitle.Text) ||
                cbStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text) ||
                numStock.Value <= 0)
            {
                MessageBox.Show("Silakan isi semua data event dan tiket!");
                return;
            }

            using (var _context = new DataContext())
            {
                // 1️⃣ Buat event baru
                Event newEvent = new Event
                {
                    Title = tbEventTitle.Text,
                    Status = cbStatus.SelectedItem.ToString(),
                    Description = rtbDescription.Text,
                    Open_date = dtOpen.Value,
                    Closed_date = dtClosed.Value
                };

                _context.Events.Add(newEvent);
                await _context.SaveChangesAsync(); // Simpan event ke database

                int selectedCategoryId = (int)cbCategory.SelectedValue;

                // 2️⃣ Jika kategori baru dibuat, simpan dulu ke database
                if (selectedCategoryId == 0)
                {
                    if (string.IsNullOrWhiteSpace(tbNewCategory.Text))
                    {
                        MessageBox.Show("Silakan isi nama kategori baru!");
                        return;
                    }

                    Category newCategory = new Category { Name = tbNewCategory.Text };
                    _context.Categories.Add(newCategory);
                    await _context.SaveChangesAsync();
                    selectedCategoryId = newCategory.Id; // Gunakan ID kategori baru
                }

                // 3️⃣ Buat tiket menggunakan kategori yang dipilih atau baru dibuat
                // Cari kategori berdasarkan ID yang dipilih
                Category selectedCategory = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);

                Ticket newTicket = new Ticket
                {
                    Total_stock = (int)numStock.Value,
                    Event = newEvent, // Hubungkan ke Event yang baru dibuat
                    Category = selectedCategory // ✅ Simpan sebagai objek Category
                };
                _context.Tickets.Add(newTicket);
                await _context.SaveChangesAsync();
            }

            LoadCategories(); // Update kategori agar kategori baru muncul
            LoadViewData(); // Refresh tampilan
            dgManagement.Refresh();
            MessageBox.Show("Event dan tiket berhasil dibuat!");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Create":
                    actionCreateWithTicket();
                    break;

            }
        }

        private void LoadCategories()
        {
            using (var context = new DataContext())
            {
                var categories = context.Categories.ToList();
                categories.Insert(0, new Category { Id = 0, Name = "Tambah Kategori Baru..." });

                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue != null && (int)cbCategory.SelectedValue == 0)
            {
                // Jika pilih "Tambah Kategori Baru", munculkan input
                lblNewCategory.Visible = true;
                tbNewCategory.Visible = true;
            }
            else
            {
                // Jika pilih kategori biasa, sembunyikan input
                lblNewCategory.Visible = false;
                tbNewCategory.Visible = false;
            }
        }
    }
}
