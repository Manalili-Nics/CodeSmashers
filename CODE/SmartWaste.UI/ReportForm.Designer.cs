namespace SmartWaste.UI
{
    partial class ReportForm
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
            label1 = new Label();
            lblTotalWasteCollected = new Label();
            lblTotalRecords = new Label();
            lblRecentEntry = new Label();
            label5 = new Label();
            dgvWasteRecords = new DataGridView();
            label6 = new Label();
            btnBackDashboard = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWasteRecords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Waste Reports";
            label1.Click += label1_Click;
            // 
            // lblTotalWasteCollected
            // 
            lblTotalWasteCollected.AutoSize = true;
            lblTotalWasteCollected.Location = new Point(159, 103);
            lblTotalWasteCollected.Name = "lblTotalWasteCollected";
            lblTotalWasteCollected.Size = new Size(121, 15);
            lblTotalWasteCollected.TabIndex = 1;
            lblTotalWasteCollected.Text = "Total Waste Collected";
            lblTotalWasteCollected.Click += label2_Click;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Location = new Point(159, 146);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(113, 15);
            lblTotalRecords.TabIndex = 2;
            lblTotalRecords.Text = "Total Waste Records";
            // 
            // lblRecentEntry
            // 
            lblRecentEntry.AutoSize = true;
            lblRecentEntry.Location = new Point(159, 184);
            lblRecentEntry.Name = "lblRecentEntry";
            lblRecentEntry.Size = new Size(103, 15);
            lblRecentEntry.TabIndex = 3;
            lblRecentEntry.Text = "Most Recent Entry";
            lblRecentEntry.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(77, 60);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 4;
            label5.Text = "Waste Summary";
            // 
            // dgvWasteRecords
            // 
            dgvWasteRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWasteRecords.Location = new Point(77, 246);
            dgvWasteRecords.Name = "dgvWasteRecords";
            dgvWasteRecords.Size = new Size(438, 192);
            dgvWasteRecords.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(77, 215);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 6;
            label6.Text = "Waste Records";
            // 
            // btnBackDashboard
            // 
            btnBackDashboard.Location = new Point(573, 298);
            btnBackDashboard.Name = "btnBackDashboard";
            btnBackDashboard.Size = new Size(145, 23);
            btnBackDashboard.TabIndex = 7;
            btnBackDashboard.Text = "Back to Dashboard";
            btnBackDashboard.UseVisualStyleBackColor = true;
            btnBackDashboard.Click += btnBackDashboard_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(573, 383);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(145, 23);
            btnExport.TabIndex = 8;
            btnExport.Text = "Download Report";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(btnBackDashboard);
            Controls.Add(label6);
            Controls.Add(dgvWasteRecords);
            Controls.Add(label5);
            Controls.Add(lblRecentEntry);
            Controls.Add(lblTotalRecords);
            Controls.Add(lblTotalWasteCollected);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvWasteRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotalWasteCollected;
        private Label lblTotalRecords;
        private Label lblRecentEntry;
        private Label label5;
        private DataGridView dgvWasteRecords;
        private Label label6;
        private Button btnBackDashboard;
        private Button btnExport;
    }
}