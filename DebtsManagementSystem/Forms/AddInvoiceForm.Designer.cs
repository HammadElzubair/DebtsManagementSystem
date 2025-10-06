namespace DebtsManagementSystem.Forms.InvoiceForms
{
    partial class AddInvoiceForm
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
            txtProduct = new TextBox();
            label2 = new Label();
            cmpCustomer = new ComboBox();
            numQty = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            btnCancle = new Button();
            numPrice = new NumericUpDown();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 53);
            label1.TabIndex = 1;
            label1.Text = "فاتوره جديده";
            // 
            // txtProduct
            // 
            txtProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtProduct.Location = new Point(155, 164);
            txtProduct.Margin = new Padding(4, 5, 4, 5);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(443, 47);
            txtProduct.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(614, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 34);
            label2.TabIndex = 3;
            label2.Text = "اختر العميل";
            // 
            // cmpCustomer
            // 
            cmpCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cmpCustomer.FormattingEnabled = true;
            cmpCustomer.Location = new Point(155, 105);
            cmpCustomer.Margin = new Padding(4);
            cmpCustomer.Name = "cmpCustomer";
            cmpCustomer.Size = new Size(443, 48);
            cmpCustomer.TabIndex = 5;
            // 
            // numQty
            // 
            numQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            numQty.Location = new Point(155, 224);
            numQty.Margin = new Padding(4, 6, 4, 6);
            numQty.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(444, 47);
            numQty.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(632, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 34);
            label3.TabIndex = 7;
            label3.Text = "المنتج";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(609, 288);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 34);
            label4.TabIndex = 9;
            label4.Text = "سعر المنتج";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(629, 231);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 34);
            label5.TabIndex = 10;
            label5.Text = "الكمية";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnCancle);
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmpCustomer);
            groupBox1.Controls.Add(numQty);
            groupBox1.Controls.Add(txtProduct);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(88, 94);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(824, 449);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافه فاتوره جديده";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(385, 348);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 43);
            btnSave.TabIndex = 11;
            btnSave.Text = "اضافة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancle.BackColor = Color.Crimson;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.ForeColor = Color.WhiteSmoke;
            btnCancle.Location = new Point(156, 348);
            btnCancle.Margin = new Padding(4, 5, 4, 5);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(215, 43);
            btnCancle.TabIndex = 12;
            btnCancle.Text = "الغاء";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(155, 284);
            numPrice.Margin = new Padding(4, 6, 4, 6);
            numPrice.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(444, 47);
            numPrice.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 68, 204);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 73);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(1743, -33);
            label6.Name = "label6";
            label6.Size = new Size(149, 53);
            label6.TabIndex = 2;
            label6.Text = "إدارة الفواتير";
            // 
            // AddInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(960, 556);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += AddInvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProduct;
        private Label label2;
        private ComboBox cmpCustomer;
        private NumericUpDown numQty;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnCancle;
        private Button btnSave;
        private NumericUpDown numPrice;
        private Panel panel2;
        private Label label6;
    }
}