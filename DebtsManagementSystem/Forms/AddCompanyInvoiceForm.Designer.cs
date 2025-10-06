namespace DebtsManagementSystem.Forms
{
    partial class AddCompanyInvoiceForm
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
            label3 = new Label();
            label4 = new Label();
            txtProduct = new TextBox();
            numQty = new NumericUpDown();
            numPrice = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel2 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 47);
            label1.TabIndex = 0;
            label1.Text = "فاتورة شراء";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 61);
            label2.Name = "label2";
            label2.Size = new Size(46, 31);
            label2.TabIndex = 1;
            label2.Text = "المنتج";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 103);
            label3.Name = "label3";
            label3.Size = new Size(47, 31);
            label3.TabIndex = 2;
            label3.Text = "الكمية";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 146);
            label4.Name = "label4";
            label4.Size = new Size(48, 31);
            label4.TabIndex = 3;
            label4.Text = "السعر";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(154, 57);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(312, 37);
            txtProduct.TabIndex = 4;
            // 
            // numQty
            // 
            numQty.Location = new Point(154, 101);
            numQty.Margin = new Padding(3, 6, 3, 6);
            numQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(312, 37);
            numQty.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(154, 147);
            numPrice.Margin = new Padding(3, 6, 3, 6);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(312, 37);
            numPrice.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(numQty);
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProduct);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(76, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 273);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "فاتورة شراء";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(154, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(312, 42);
            btnSave.TabIndex = 8;
            btnSave.Text = "اضافة";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 68, 204);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 73);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(944, -5);
            label5.Name = "label5";
            label5.Size = new Size(149, 53);
            label5.TabIndex = 2;
            label5.Text = "إدارة الفواتير";
            // 
            // AddCompanyInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(768, 544);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Font = new Font("Simplified Arabic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCompanyInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += AddCompanyInvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProduct;
        private NumericUpDown numQty;
        private NumericUpDown numPrice;
        private GroupBox groupBox1;
        private Button btnSave;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Panel panel2;
        private Label label5;
    }
}