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
    public partial class TicketPayment : Form
    {
        private DataContext _context = new DataContext();
        private List<DetailTransaction> _keranjang = new List<DetailTransaction>();
        private int _selectedEventId;
        public TicketPayment()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            var events = _context.Events.ToList();
            cbEvent.DataSource = events;
            cbEvent.DisplayMember = "Title";
            cbEvent.ValueMember = "Id";
        }

        private void LoadTickets(int eventId)
        {
            var tickets = _context.Tickets
                .Where(t => t.EventId == eventId)
                .Select(t => new
                {
                    t.Id,
                    EventName = t.Event.Title, // Menggunakan nama event sebagai judul tiket
                    Category = t.Category.Name, // Nama kategori tiket
                    t.Price,
                    t.Total_stock
                })
                .ToList();

            dgvTicket.DataSource = tickets;
        }


        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEvent.SelectedItem is Event selectedEvent)
            {
                _selectedEventId = selectedEvent.Id;
                LoadTickets(_selectedEventId);
            }
        }


        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows.Count == 0 || numJumlahBeli.Value <= 0)
                return;

            int selectedTicketId = (int)dgvTicket.SelectedRows[0].Cells["Id"].Value;
            var selectedTicket = _context.Tickets
            .Include(t => t.Category)
            .FirstOrDefault(t => t.Id == selectedTicketId);

            int quantity = (int)numJumlahBeli.Value;

            if (quantity > selectedTicket.Total_stock)
            {
                MessageBox.Show("Stok tiket tidak mencukupi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan di memori 
            var detail = new DetailTransaction
            {
                TicketId = selectedTicket.Id,
                Ticket = selectedTicket,
                Quantity = quantity
            };
            _keranjang.Add(detail);
            UpdateKeranjang();
            tbTotalHarga.Text = _keranjang.Sum(k => k.Ticket.Price * k.Quantity).ToString();
        }

        private void UpdateKeranjang()
        {
            var keranjangView = _keranjang.Select(k => new
            {
                NamaTiket = k.Ticket.Event.Title,
                Kategori = k.Ticket.Category?.Name ?? "Tidak Ada",
                Harga = k.Ticket.Price,
                Jumlah = k.Quantity,
                Total = k.Ticket.Price * k.Quantity
            }).ToList();

            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = keranjangView;
        }


        private void btnHapusTiket_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.SelectedRows.Count == 0)
                return;

            var selectedDetail = (DetailTransaction)dgvKeranjang.SelectedRows[0].DataBoundItem;
            _keranjang.Remove(selectedDetail);
            UpdateKeranjang();
        }

        private void btnHitungKembalian_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbUangDiberikan.Text, out int uangDiberikan))
            {
                int totalHarga = int.Parse(tbTotalHarga.Text);
                tbKembalian.Text = (uangDiberikan - totalHarga).ToString();
            }
            else
            {
                MessageBox.Show("Uang diberikan harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProsesPembelian_Click(object sender, EventArgs e)
        {
            if (_keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedEvent = _context.Events.FirstOrDefault(e => e.Id == _selectedEventId);
            if (selectedEvent == null)
            {
                MessageBox.Show("Event tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transaction = new Transaction
            {
                Customer_name = tbNamaPemesan.Text,
                Customer_phone = tbNoHpPemesan.Text,
                Event = selectedEvent,
                Buying_at = DateTime.Now
            };
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            foreach (var detail in _keranjang)
            {
                detail.TransactionId = transaction.Id;
                _context.DetailTransactions.Add(detail);

                var ticket = _context.Tickets.Find(detail.TicketId);
                if (ticket != null)
                {
                    ticket.Total_stock -= detail.Quantity;
                }
            }

            _context.SaveChanges();
            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ResetForm()
        {
            tbNamaPemesan.Text = "";
            tbNoHpPemesan.Text = "";
            tbUangDiberikan.Text = "";
            tbKembalian.Text = "";
            tbTotalHarga.Text = "";
            numJumlahBeli.Value = 0;
            _keranjang.Clear();
            UpdateKeranjang();
        }
    }
}
