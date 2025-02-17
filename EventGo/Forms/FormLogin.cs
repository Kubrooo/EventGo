
using EventGo.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EventGo
{
    public partial class FormLogin : Form
    {
        DataContext _context;
        public FormLogin()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context.Database.EnsureCreated();
            tbEmail.Text = "ardiansyah@gmail.com";
            tbPassword.Text = "12345";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length <= 0 || tbPassword.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the field properly");
            }

            var userData = await _context.Users.Where(e => e.Email == tbEmail.Text).FirstOrDefaultAsync();
            string nameUser = userData.Name.ToString();

            if(userData == null)
            {
                MessageBox.Show("user tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                if(userData.Password == tbPassword.Text)
                {
                    if(userData.Role == "Event Manager")
                    {
                        int id = userData.Id;
                        this.Hide();
                        EventTicketManagement eventTicketManagement = new EventTicketManagement();
                        eventTicketManagement.Show();
                    } else if(userData.Role == "Petugas Tiket")
                    {
                        int id = userData.Id;
                        this.Hide();
                        TicketPayment ticketPayment = new TicketPayment();
                        ticketPayment.Show();
                    }
                }
            }
        }
    }
}
