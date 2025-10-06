namespace DebtsManagementSystem.Forms
{
    partial class InvoiceForm
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
            dgvInvoice = new DataGridView();
            btnPayment = new Button();
            btnEdit = new Button();
            panel1 = new Panel();
            btnDelete = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dtStart = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtEnd = new DateTimePicker();
            btnSearch = new Button();
            btnNewInvoiceForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(660, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 53);
            label1.TabIndex = 2;
            label1.Text = "إدارة الفواتير";
            // 
            // dgvInvoice
            // 
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.AllowUserToDeleteRows = false;
            dgvInvoice.BackgroundColor = Color.LightGray;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Dock = DockStyle.Fill;
            dgvInvoice.Location = new Point(0, 0);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.ReadOnly = true;
            dgvInvoice.RightToLeft = RightToLeft.Yes;
            dgvInvoice.RowHeadersWidth = 62;
            dgvInvoice.RowTemplate.Height = 33;
            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.Size = new Size(1422, 495);
            dgvInvoice.TabIndex = 4;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPayment.BackColor = Color.DarkGreen;
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayment.ForeColor = Color.WhiteSmoke;
            btnPayment.Location = new Point(1321, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(128, 40);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "سداد دفعه";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.DarkSlateBlue;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(1187, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 651);
            panel1.Name = "panel1";
            panel1.Size = new Size(1503, 52);
            panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(1053, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 68, 204);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1503, 73);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvInvoice);
            panel3.Location = new Point(57, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(1422, 495);
            panel3.TabIndex = 9;
            // 
            // dtStart
            // 
            dtStart.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Location = new Point(136, 103);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(295, 37);
            dtStart.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 103);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 11;
            label2.Text = "من الفتره";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(452, 101);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 13;
            label3.Text = "الي الفتره";
            // 
            // dtEnd
            // 
            dtEnd.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtEnd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.Location = new Point(548, 99);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(295, 37);
            dtEnd.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(96, 68, 204);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(861, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 40);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNewInvoiceForm
            // 
            btnNewInvoiceForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewInvoiceForm.BackColor = Color.FromArgb(96, 68, 204);
            btnNewInvoiceForm.Cursor = Cursors.Hand;
            btnNewInvoiceForm.FlatStyle = FlatStyle.Flat;
            btnNewInvoiceForm.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewInvoiceForm.ForeColor = Color.WhiteSmoke;
            btnNewInvoiceForm.Location = new Point(1345, 89);
            btnNewInvoiceForm.Name = "btnNewInvoiceForm";
            btnNewInvoiceForm.Size = new Size(134, 40);
            btnNewInvoiceForm.TabIndex = 14;
            btnNewInvoiceForm.Text = "اضافه فاتوره جديده";
            btnNewInvoiceForm.UseVisualStyleBackColor = false;
            btnNewInvoiceForm.Click += btnNewInvoiceForm_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1503, 703);
            Controls.Add(btnNewInvoiceForm);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(dtEnd);
            Controls.Add(label2);
            Controls.Add(dtStart);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "InvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "InvoiceForm";
            WindowState = FormWindowState.Maximized;
            Load += InvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvInvoice;
        private Button btnPayment;
        private Button btnEdit;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnDelete;
        private DateTimePicker dtStart;
        private Label label2;
        private Label label3;
        private DateTimePicker dtEnd;
        private Button btnSearch;
        private Button btnNewInvoiceForm;
    }
}