namespace SmartWaste.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbWasteType = new ComboBox();
            label4 = new Label();
            txtHousehold = new TextBox();
            txtWasteAmount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            btnSubmit = new Button();
            lblTotalWaste = new Label();
            dgvWasteRecords = new DataGridView();
            btnReports = new Button();
            btnLogout = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWasteRecords).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(984, 43);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 32);
            label1.TabIndex = 0;
            label1.Text = "Smart Waste Management Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(82, 63);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 1;
            label2.Text = "Add Waste Entry";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(82, 170);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Waste Type";
            // 
            // cmbWasteType
            // 
            cmbWasteType.FormattingEnabled = true;
            cmbWasteType.Location = new Point(304, 170);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(192, 23);
            cmbWasteType.TabIndex = 3;
            cmbWasteType.SelectedIndexChanged += cmbWasteType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(82, 113);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 4;
            label4.Text = "Household Name";
            // 
            // txtHousehold
            // 
            txtHousehold.Location = new Point(304, 111);
            txtHousehold.Name = "txtHousehold";
            txtHousehold.Size = new Size(192, 23);
            txtHousehold.TabIndex = 5;
            txtHousehold.TextChanged += txtHousehold_TextChanged;
            // 
            // txtWasteAmount
            // 
            txtWasteAmount.Location = new Point(304, 221);
            txtWasteAmount.Name = "txtWasteAmount";
            txtWasteAmount.Size = new Size(192, 23);
            txtWasteAmount.TabIndex = 6;
            txtWasteAmount.TextChanged += txtWasteAmount_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(82, 223);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 7;
            label5.Text = "Waste Amount (kg)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(82, 287);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 8;
            label6.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(304, 285);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(73, 350);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 40);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit Entry";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblTotalWaste
            // 
            lblTotalWaste.AutoSize = true;
            lblTotalWaste.Font = new Font("Segoe UI", 11F);
            lblTotalWaste.Location = new Point(335, 359);
            lblTotalWaste.Name = "lblTotalWaste";
            lblTotalWaste.Size = new Size(121, 20);
            lblTotalWaste.TabIndex = 11;
            lblTotalWaste.Text = "Total Waste: 0 kg";
            // 
            // dgvWasteRecords
            // 
            dgvWasteRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWasteRecords.ImeMode = ImeMode.Hiragana;
            dgvWasteRecords.Location = new Point(574, 63);
            dgvWasteRecords.Name = "dgvWasteRecords";
            dgvWasteRecords.Size = new Size(398, 245);
            dgvWasteRecords.TabIndex = 13;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(618, 350);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 15;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(819, 350);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(dgvWasteRecords);
            Controls.Add(lblTotalWaste);
            Controls.Add(btnSubmit);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtWasteAmount);
            Controls.Add(txtHousehold);
            Controls.Add(label4);
            Controls.Add(cmbWasteType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelHeader);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Waste Management Dashboard";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWasteRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbWasteType;
        private Label label4;
        private TextBox txtHousehold;
        private TextBox txtWasteAmount;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDate;
        private Button btnSubmit;
        private Label lblTotalWaste;
        private DataGridView dgvWasteRecords;
        private Button btnReports;
        private Button btnLogout;
    }
}
