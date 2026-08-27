using MiniERP.winforms.Pages;

namespace MiniERP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ShowPage(new DashboardPage());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
        }   

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowPage(new CustomersPage());
        }

        private void ShowPage(UserControl page)
        {
            panelContent.Controls.Clear();

            page.Dock = DockStyle.Fill;

            panelContent.Controls.Add(page);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(new DashboardPage());
        }
    }
}