using MiniERP.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace MiniERP.winforms
{
    public partial class CustomersForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7167/")
        };
        public CustomersForm()
        {
            InitializeComponent();

            Load += async (sender, e) => await LoadCustomers();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task LoadCustomers()
        {
            try
            {
                var customers = await _httpClient
                    .GetFromJsonAsync<List<CustomerDto>>("api/Customers");

                dgvCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load customers:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
