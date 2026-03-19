namespace SmartWaste.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 21);
            label1.TabIndex = 0;
            label1.Text = "Smart Waste Management System";
            label1.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(256, 161);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.Click += txtPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 295);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(256, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            lblUsername.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(193, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 23);
            txtUsername.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(239, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Waste Management Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label label2;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}