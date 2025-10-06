namespace DebtsManagementSystem.Forms
{
    partial class CustomrtForm
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
            dgvCustomer = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(492, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 53);
            label1.TabIndex = 2;
            label1.Text = "ادارة العملاء";
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.BackgroundColor = Color.Gainsboro;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(12, 152);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RightToLeft = RightToLeft.Yes;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.RowTemplate.Height = 33;
            dgvCustomer.Size = new Size(1076, 325);
            dgvCustomer.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(95, 68, 204);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(946, 98);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 47);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "اضافة عميل جديد";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(95, 68, 204);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(946, 484);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(143, 47);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "رجوع";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 68, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 71);
            panel1.TabIndex = 30;
            // 
            // CustomrtForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1114, 540);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomer);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CustomrtForm";
            Load += CustomrtForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvCustomer;
        private Button btnAdd;
        private Button btnEdit;
        private Panel panel1;
    }
}