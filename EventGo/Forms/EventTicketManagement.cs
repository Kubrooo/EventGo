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
    public partial class EventTicketManagement : Form
    {
        EventManagementForm eventManagementForm;
        TicketManagementForm ticketManagementForm;
        SponsorshipManagement SponsorshipManagement;
        Form currentOpenForm;
        public EventTicketManagement()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (eventManagementForm == null)
            {
                closeCurrentForm();
                eventManagementForm = new EventManagementForm();
                eventManagementForm.MdiParent = this;
                eventManagementForm.Dock = DockStyle.Fill;
                eventManagementForm.Show();
                currentOpenForm = eventManagementForm;
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (ticketManagementForm == null)
            {
                closeCurrentForm();
                ticketManagementForm = new TicketManagementForm();
                ticketManagementForm.MdiParent = this;
                ticketManagementForm.Dock = DockStyle.Fill;
                ticketManagementForm.Show();
                currentOpenForm = ticketManagementForm;
            }
        }

        private void closeCurrentForm()
        {
            eventManagementForm = null;
            ticketManagementForm = null;

            if (currentOpenForm != null)
            {
                currentOpenForm.Close();
            }
        }

        private void btnSponsorship_Click(object sender, EventArgs e)
        {
            if(ticketManagementForm == null)
            {
                closeCurrentForm();
                SponsorshipManagement = new SponsorshipManagement();
                SponsorshipManagement.MdiParent = this;
                SponsorshipManagement.Dock = DockStyle.Fill;
                SponsorshipManagement.Show();
                currentOpenForm = SponsorshipManagement;
            }
        }
    }
}
