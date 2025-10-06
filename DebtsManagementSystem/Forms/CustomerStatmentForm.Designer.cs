namespace DebtsManagementSystem.Forms
{
    partial class CustomerStatmentForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            dtEnd = new DateTimePicker();
            label6 = new Label();
            dtStart = new DateTimePicker();
            txtBalance = new TextBox();
            txtSataus = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnExportAsPdf = new Button();
            btnSearch = new Button();
            label2 = new Label();
            dgvStatment = new DataGridView();
            cmpCustomer = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(597, 2);
            label1.Name = "label1";
            label1.Size = new Size(153, 53);
            label1.TabIndex = 17;
            label1.Text = "كشف حساب";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 68, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1351, 71);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtEnd);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtStart);
            panel2.Controls.Add(txtBalance);
            panel2.Controls.Add(txtSataus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExportAsPdf);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvStatment);
            panel2.Controls.Add(cmpCustomer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1351, 603);
            panel2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(292, 40);
            label5.Name = "label5";
            label5.Size = new Size(78, 35);
            label5.TabIndex = 42;
            label5.Text = "الي الفتره";
            // 
            // dtEnd
            // 
            dtEnd.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtEnd.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.Location = new Point(61, 76);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(295, 34);
            dtEnd.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(612, 39);
            label6.Name = "label6";
            label6.Size = new Size(76, 35);
            label6.TabIndex = 40;
            label6.Text = "من الفتره";
            // 
            // dtStart
            // 
            dtStart.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Location = new Point(379, 76);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(295, 34);
            dtStart.TabIndex = 39;
            // 
            // txtBalance
            // 
            txtBalance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBalance.BackColor = Color.WhiteSmoke;
            txtBalance.Location = new Point(61, 512);
            txtBalance.Name = "txtBalance";
            txtBalance.RightToLeft = RightToLeft.Yes;
            txtBalance.Size = new Size(150, 41);
            txtBalance.TabIndex = 38;
            // 
            // txtSataus
            // 
            txtSataus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtSataus.BackColor = Color.WhiteSmoke;
            txtSataus.Location = new Point(357, 512);
            txtSataus.Name = "txtSataus";
            txtSataus.RightToLeft = RightToLeft.Yes;
            txtSataus.Size = new Size(150, 41);
            txtSataus.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(217, 515);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(108, 34);
            label4.TabIndex = 36;
            label4.Text = "الرصيد النهائي";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(513, 515);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(51, 34);
            label3.TabIndex = 35;
            label3.Text = "الحالة";
            // 
            // btnExportAsPdf
            // 
            btnExportAsPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportAsPdf.BackColor = Color.DarkSlateGray;
            btnExportAsPdf.Cursor = Cursors.Hand;
            btnExportAsPdf.FlatStyle = FlatStyle.Flat;
            btnExportAsPdf.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportAsPdf.ForeColor = Color.WhiteSmoke;
            btnExportAsPdf.Location = new Point(1133, 512);
            btnExportAsPdf.Name = "btnExportAsPdf";
            btnExportAsPdf.RightToLeft = RightToLeft.Yes;
            btnExportAsPdf.Size = new Size(157, 42);
            btnExportAsPdf.TabIndex = 34;
            btnExportAsPdf.Text = "تصدير الي PDF";
            btnExportAsPdf.UseVisualStyleBackColor = false;
            btnExportAsPdf.Click += btnExportAsPdf_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(95, 68, 204);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(852, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.Yes;
            btnSearch.Size = new Size(128, 42);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "كشف الحساب";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1203, 39);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(87, 34);
            label2.TabIndex = 31;
            label2.Text = "اختر العميل";
            // 
            // dgvStatment
            // 
            dgvStatment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStatment.BackgroundColor = Color.LightGray;
            dgvStatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatment.Location = new Point(61, 134);
            dgvStatment.Name = "dgvStatment";
            dgvStatment.RightToLeft = RightToLeft.Yes;
            dgvStatment.RowHeadersWidth = 62;
            dgvStatment.RowTemplate.Height = 33;
            dgvStatment.Size = new Size(1229, 372);
            dgvStatment.TabIndex = 30;
            // 
            // cmpCustomer
            // 
            cmpCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmpCustomer.BackColor = Color.WhiteSmoke;
            cmpCustomer.FormattingEnabled = true;
            cmpCustomer.Location = new Point(986, 76);
            cmpCustomer.Name = "cmpCustomer";
            cmpCustomer.RightToLeft = RightToLeft.Yes;
            cmpCustomer.Size = new Size(304, 42);
            cmpCustomer.TabIndex = 29;
            // 
            // CustomerStatmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1351, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Simplified Arabic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerStatmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += CustomerStatmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtBalance;
        private TextBox txtSataus;
        private Label label4;
        private Label label3;
        private Button btnExportAsPdf;
        private Button btnSearch;
        private Label label2;
        private DataGridView dgvStatment;
        private ComboBox cmpCustomer;
        private Label label5;
        private DateTimePicker dtEnd;
        private Label label6;
        private DateTimePicker dtStart;
    }
}