using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using ProductivityApp.Core.Data;
using ProductivityApp.Core.Data.Models;
using System.ComponentModel;

namespace ProductivityApp.WindowsForms
{
    public partial class MainForm : Form
    {
        private DataDbContext? _dbContext = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _dbContext = new DataDbContextFactory().CreateDbContext(new string[]{ });

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            ButtonClicks click = new ButtonClicks()
            {
                
            };
            _dbContext?.Add(click);
            _dbContext?.SaveChanges();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
