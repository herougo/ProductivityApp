using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using ProductivityApp.Core.Data;
using ProductivityApp.Core.Data.Models;
using System.ComponentModel;
using System.Data.SqlTypes;

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
            var buttonClick = _dbContext?.ButtonClick.FirstOrDefaultAsync(
                m => m.ClickedAt >= DateTime.Today && m.ClickType == ClickType.Ready
            );
            if (buttonClick != null)
            {
                tbReadyMessage.Text = "Already clicked today!";
                return;
            }
            
            DateTime now = DateTime.Now;
            ButtonClick click = new ButtonClick()
            {
                ClickType = ClickType.Ready,
                ClickedAt = now,
            };
            _dbContext?.Add(click);
            _dbContext?.SaveChanges();

            HandleReadyClick(now);
        }

        public void HandleReadyClick(DateTime now)
        {
            if (now < DateTime.Today.AddMinutes(60 * 10 + 15))
            {
                pbReadyImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\thanos.png");
                tbReadyMessage.Text = "Go get 'em, Thanos!";
            }
            else if (now < DateTime.Today.AddMinutes(60 * 11 + 15))
            {
                pbReadyImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\thor.png");
                tbReadyMessage.Text = "Go get 'em, Thor!";
            }
            pbReadyImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\iron_man.jpg");
            tbReadyMessage.Text = "Go get 'em, Iron Man!";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
