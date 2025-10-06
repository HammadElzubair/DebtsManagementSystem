namespace DebtsManagementSystem.Forms
{
    partial class ManagePaymentsForm
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
            panel2 = new Panel();
            btnSearch = new Button();
            cmpCustomer = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dgvPayments = new DataGridView();
            panel3 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cmpCustomer);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(1210, 529);
            panel2.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(95, 68, 204);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(725, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 40);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "عرض السدادات";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmpCustomer
            // 
            cmpCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmpCustomer.FormattingEnabled = true;
            cmpCustomer.Location = new Point(861, 16);
            cmpCustomer.Name = "cmpCustomer";
            cmpCustomer.Size = new Size(228, 42);
            cmpCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1095, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 35);
            label2.TabIndex = 1;
            label2.Text = "اختر العميل";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvPayments);
            groupBox1.Font = new Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1140, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جدول السدادات";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.BackgroundColor = Color.LightGray;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.Location = new Point(3, 49);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.RowTemplate.Height = 29;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1134, 347);
            dgvPayments.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 533);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 65);
            panel3.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(913, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(95, 68, 204);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(1047, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(514, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 53);
            label1.TabIndex = 4;
            label1.Text = "إدارة السدادات";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 68, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 69);
            panel1.TabIndex = 5;
            // 
            // ManagePaymentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 598);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Simplified Arabic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagePaymentsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += ManagePaymentsForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Button btnEdit;
        private DataGridView dgvPayments;
        private ComboBox cmpCustomer;
        private Label label2;
        private Button btnSearch;
        private Button btnDelete;
        private Label label1;
        private Panel panel1;
    }
}