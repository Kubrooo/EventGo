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
    public partial class SummaryForm : Form
    {
        private int _eventId;
        private DataContext _context = new DataContext();
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            disableField();
            loadcBeventList();
        }

        private void disableField()
        {
            txtEventName.Enabled = false;
            rtbDesctiption.Enabled = false;
            dtStartDate.Enabled = false;
            dtEndDate.Enabled = false;
            txtEventStatus.Enabled = false;
            txtTotalTicketRevenue.Enabled = false;
            txtTotalSponsorship.Enabled = false;
            txtTotalRevenue.Enabled = false;
            txtSalesPercentage.Enabled = false;
            txtSponsorshipPercentage.Enabled = false;
        }
        private void loadcBeventList()
        {
            var events = _context.Events.ToList();
            cbEventList.DataSource = events;
            cbEventList.DisplayMember = "Title";
            cbEventList.ValueMember = "Id";
        }

        private void loadEventSummary(int eventId)
        {
            var events = _context.Events.Where(e => e.Id == eventId)
                .Select(e => new
                {
                    e.Title,
                    e.Description,
                    e.Open_date,
                    e.Closed_date,
                    e.Status,
                })
                .FirstOrDefault();
            if (events != null)
            {
                txtEventName.Text = events.Title;
                rtbDesctiption.Text = events.Description;
                dtStartDate.Value = events.Open_date;
                dtEndDate.Value = events.Closed_date;
                txtEventStatus.Text = events.Status;

                loadFinanceAndStatistic(eventId);
            }
            else
            {
                MessageBox.Show("Event not found");
            }
        }

        private void loadFinanceAndStatistic(int eventId)
        {
            var ticketRevenue = _context.DetailTransactions
                .Where(dt => dt.Ticket.EventId == _eventId)
                .Sum(dt => dt.TotalPrice);

            var sponsorship = _context.Sponsors.Where(s => s.EventId == eventId && s.deleted_at == null)
                .Sum(s => Convert.ToDecimal(s.Budget));

            var totalStock = _context.Tickets.Where(t => t.EventId == eventId)
                .Sum(t => t.Total_stock);

            var totalTicketSold = _context.DetailTransactions
                .Where(dt => dt.Ticket.EventId == eventId)
                .Sum(dt => dt.Quantity);

            decimal totalRevenue = ticketRevenue + sponsorship;

            decimal ticketSalesPercentage = totalStock > 0 ? ((decimal)ticketRevenue / totalRevenue) * 100 : 0;
            decimal sponsorshipPercentage = totalRevenue > 0 ? (sponsorship / totalRevenue) * 100 : 0;

            txtTotalTicketRevenue.Text = ticketRevenue.ToString();
            txtTotalSponsorship.Text = sponsorship.ToString();
            txtTotalRevenue.Text = totalRevenue.ToString();
            txtSalesPercentage.Text = $"{ticketSalesPercentage:0.00} %";
            txtSponsorshipPercentage.Text = $"{sponsorshipPercentage:0.00} %";

        }

        private void cbEventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEventList.SelectedItem is Event selectedEvent)
            {
                _eventId = selectedEvent.Id;
                loadEventSummary(_eventId);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

