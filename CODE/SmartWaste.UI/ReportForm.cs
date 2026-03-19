using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SmartWaste.UI
{
    public partial class ReportForm : Form
    {
        string connectionString = DatabaseHelper.ConnectionString;

        public ReportForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT HouseholdName, WasteType, WasteAmount, Date FROM WasteEntries";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvWasteRecords.DataSource = table;

                lblTotalRecords.Text = "Total Records: " + table.Rows.Count;

                double totalWaste = 0;

                foreach (DataRow row in table.Rows)
                {
                    if (row["WasteAmount"] != DBNull.Value)
                        totalWaste += Convert.ToDouble(row["WasteAmount"]);
                }

                lblTotalWasteCollected.Text = "Total Waste Collected: " + totalWaste + " kg";

                if (table.Rows.Count > 0)
                {
                    DataRow lastRow = table.Rows[table.Rows.Count - 1];

                    lblRecentEntry.Text =
                        "Most Recent Entry: " +
                        lastRow["HouseholdName"].ToString() +
                        " - " +
                        lastRow["WasteType"].ToString();
                }
                else
                {
                    lblRecentEntry.Text = "Most Recent Entry: None";
                }
            }
        }

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File (*.csv)|*.csv";
            save.Title = "Download Waste Report";
            save.FileName = "WasteReport.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    for (int i = 0; i < dgvWasteRecords.Columns.Count; i++)
                    {
                        writer.Write(dgvWasteRecords.Columns[i].HeaderText);

                        if (i < dgvWasteRecords.Columns.Count - 1)
                            writer.Write(",");
                    }

                    writer.WriteLine();

                    foreach (DataGridViewRow row in dgvWasteRecords.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvWasteRecords.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value?.ToString());

                                if (i < dgvWasteRecords.Columns.Count - 1)
                                    writer.Write(",");
                            }

                            writer.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Report downloaded successfully!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }
}