
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
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
    }
}
