using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmartWaste.UI
{
    public partial class Form1 : Form
    {
        string connectionString = DatabaseHelper.ConnectionString;

        public Form1()
        {
            InitializeComponent();
            LoadWasteTypes();
            LoadWasteRecords();
            LoadTotalWaste();
        }

        private void LoadWasteTypes()
        {
            cmbWasteType.Items.Clear();
            cmbWasteType.Items.Add("Paper");
            cmbWasteType.Items.Add("Food");
            cmbWasteType.Items.Add("Plastic");
        }

        private void LoadWasteRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT HouseholdName, WasteType, WasteAmount, Date FROM WasteEntries";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvWasteRecords.DataSource = table;
            }
        }

        private void LoadTotalWaste()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(WasteAmount) FROM WasteEntries";

                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                object result = cmd.ExecuteScalar();

                double totalWaste = 0;

                if (result != DBNull.Value)
                    totalWaste = Convert.ToDouble(result);

                lblTotalWaste.Text = "Total Waste: " + totalWaste + " kg";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string household = txtHousehold.Text.Trim();
            string wasteType = cmbWasteType.SelectedItem != null ? cmbWasteType.SelectedItem.ToString() : "";

            if (household == "" || wasteType == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (!double.TryParse(txtWasteAmount.Text, out double wasteAmount))
            {
                MessageBox.Show("Enter valid waste amount.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query =
                @"INSERT INTO WasteEntries
                (HouseholdName, WasteType, WasteAmount, Date)
                VALUES (@household,@type,@amount,@date)";

                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@household", household);
                cmd.Parameters.AddWithValue("@type", wasteType);
                cmd.Parameters.AddWithValue("@amount", wasteAmount);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Waste entry saved!");

            txtHousehold.Clear();
            txtWasteAmount.Clear();
            cmbWasteType.SelectedIndex = -1;

            LoadWasteRecords();
            LoadTotalWaste();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void cmbWasteType_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtHousehold_TextChanged(object sender, EventArgs e) { }

        private void txtWasteAmount_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
    }
}