namespace DebtsManagementSystem.Forms
{
    partial class EditPaymentForm
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
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            txtNote = new TextBox();
            dtPaymentDate = new DateTimePicker();
            txtTransactionNo = new TextBox();
            txtAmount = new TextBox();
            txtCustomerName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 68, 204);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 67);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(921, 515);
            panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(dtPaymentDate);
            groupBox1.Controls.Add(txtTransactionNo);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(59, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(783, 369);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "تعديل السدادات";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(95, 68, 204);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(397, 301);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 42);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNote.Location = new Point(168, 248);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(368, 47);
            txtNote.TabIndex = 9;
            // 
            // dtPaymentDate
            // 
            dtPaymentDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtPaymentDate.CalendarFont = new Font("Simplified Arabic Fixed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dtPaymentDate.Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtPaymentDate.Location = new Point(168, 201);
            dtPaymentDate.Name = "dtPaymentDate";
            dtPaymentDate.Size = new Size(368, 47);
            dtPaymentDate.TabIndex = 8;
            // 
            // txtTransactionNo
            // 
            txtTransactionNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransactionNo.Location = new Point(168, 154);
            txtTransactionNo.Name = "txtTransactionNo";
            txtTransactionNo.Size = new Size(368, 47);
            txtTransactionNo.TabIndex = 7;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAmount.Location = new Point(168, 103);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(368, 47);
            txtAmount.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCustomerName.Location = new Point(168, 53);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(368, 47);
            txtCustomerName.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(546, 251);
            label6.Name = "label6";
            label6.Size = new Size(89, 41);
            label6.TabIndex = 4;
            label6.Text = "ملاحظات";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(542, 206);
            label5.Name = "label5";
            label5.Size = new Size(114, 41);
            label5.TabIndex = 3;
            label5.Text = "تاريخ السداد";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(546, 157);
            label4.Name = "label4";
            label4.Size = new Size(102, 41);
            label4.TabIndex = 2;
            label4.Text = "رقم العملية";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(556, 106);
            label3.Name = "label3";
            label3.Size = new Size(63, 41);
            label3.TabIndex = 1;
            label3.Text = "المبلغ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(546, 56);
            label2.Name = "label2";
            label2.Size = new Size(103, 41);
            label2.TabIndex = 0;
            label2.Text = "اسم العميل";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(387, 7);
            label7.Name = "label7";
            label7.Size = new Size(179, 53);
            label7.TabIndex = 17;
            label7.Text = "تعديل السدادات";
            // 
            // EditPaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 582);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Simplified Arabic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditPaymentForm";
            RightToLeftLayout = true;
            Load += EditPaymentForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private Button btnEdit;
        private TextBox txtNote;
        private DateTimePicker dtPaymentDate;
        private TextBox txtTransactionNo;
        private TextBox txtAmount;
        private TextBox txtCustomerName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}