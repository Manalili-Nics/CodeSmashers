using System;
using System.Windows.Forms;

namespace SmartWaste.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                Form1 dashboard = new Form1();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtPassword_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }
    }
}