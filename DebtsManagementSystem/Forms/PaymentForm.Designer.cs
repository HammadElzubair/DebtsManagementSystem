namespace DebtsManagementSystem.Forms
{
    partial class PaymentForm
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
            label2 = new Label();
            numAmount = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnPay = new Button();
            btnCancle = new Button();
            label5 = new Label();
            txtBankNo = new TextBox();
            cmpCustomer = new ComboBox();
            cmpInvoice = new ComboBox();
            dtPaymentDate = new DateTimePicker();
            txtNote = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 53);
            label1.TabIndex = 3;
            label1.Text = "سداد فاتورة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(641, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 34);
            label2.TabIndex = 5;
            label2.Text = "اسم العميل";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(255, 249);
            numAmount.Margin = new Padding(3, 7, 3, 7);
            numAmount.Maximum = new decimal(new int[] { 821592135, 229956, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(366, 41);
            numAmount.TabIndex = 6;
            numAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(666, 251);
            label3.Name = "label3";
            label3.Size = new Size(51, 34);
            label3.TabIndex = 7;
            label3.Text = "المبلغ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(638, 104);
            label4.Name = "label4";
            label4.Size = new Size(85, 34);
            label4.TabIndex = 9;
            label4.Text = "رقم الفاتورة";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.DarkGreen;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.WhiteSmoke;
            btnPay.Location = new Point(255, 349);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(180, 50);
            btnPay.TabIndex = 10;
            btnPay.Text = "دفع";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Crimson;
            btnCancle.Cursor = Cursors.Hand;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.ForeColor = Color.WhiteSmoke;
            btnCancle.Location = new Point(441, 349);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(180, 50);
            btnCancle.TabIndex = 11;
            btnCancle.Text = "الغاء";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(641, 155);
            label5.Name = "label5";
            label5.Size = new Size(82, 34);
            label5.TabIndex = 13;
            label5.Text = "رقم العملية";
            // 
            // txtBankNo
            // 
            txtBankNo.Location = new Point(255, 152);
            txtBankNo.Margin = new Padding(3, 4, 3, 4);
            txtBankNo.Name = "txtBankNo";
            txtBankNo.Size = new Size(366, 41);
            txtBankNo.TabIndex = 12;
            txtBankNo.TextAlign = HorizontalAlignment.Center;
            // 
            // cmpCustomer
            // 
            cmpCustomer.FormattingEnabled = true;
            cmpCustomer.Location = new Point(255, 48);
            cmpCustomer.Name = "cmpCustomer";
            cmpCustomer.Size = new Size(366, 42);
            cmpCustomer.TabIndex = 14;
            // 
            // cmpInvoice
            // 
            cmpInvoice.FormattingEnabled = true;
            cmpInvoice.Location = new Point(255, 101);
            cmpInvoice.Name = "cmpInvoice";
            cmpInvoice.Size = new Size(366, 42);
            cmpInvoice.TabIndex = 15;
            // 
            // dtPaymentDate
            // 
            dtPaymentDate.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtPaymentDate.Location = new Point(255, 200);
            dtPaymentDate.Name = "dtPaymentDate";
            dtPaymentDate.Size = new Size(366, 34);
            dtPaymentDate.TabIndex = 16;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(255, 301);
            txtNote.Margin = new Padding(3, 4, 3, 4);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(366, 41);
            txtNote.TabIndex = 17;
            txtNote.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(660, 205);
            label6.Name = "label6";
            label6.Size = new Size(57, 34);
            label6.TabIndex = 18;
            label6.Text = "التاريخ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(651, 308);
            label7.Name = "label7";
            label7.Size = new Size(72, 34);
            label7.TabIndex = 19;
            label7.Text = "ملاحظات";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 68, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 69);
            panel1.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(dtPaymentDate);
            groupBox1.Controls.Add(numAmount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnPay);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnCancle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBankNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmpCustomer);
            groupBox1.Controls.Add(cmpInvoice);
            groupBox1.Location = new Point(34, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 443);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "سداد الفواتير";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 589);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Simplified Arabic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numAmount;
        private Label label3;
        private Label label4;
        private Button btnPay;
        private Button btnCancle;
        private Label label5;
        private TextBox txtBankNo;
        private ComboBox cmpCustomer;
        private ComboBox cmpInvoice;
        private DateTimePicker dtPaymentDate;
        private TextBox txtNote;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}