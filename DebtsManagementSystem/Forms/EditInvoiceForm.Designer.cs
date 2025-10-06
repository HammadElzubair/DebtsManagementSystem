namespace DebtsManagementSystem.Forms
{
    partial class EditInvoiceForm
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
            cmpCustomer = new ComboBox();
            btnCancle = new Button();
            btnEdit = new Button();
            label4 = new Label();
            label3 = new Label();
            numPrice = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            txtProduct = new TextBox();
            label6 = new Label();
            numQty = new NumericUpDown();
            label5 = new Label();
            dtDate = new DateTimePicker();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmpCustomer
            // 
            cmpCustomer.FormattingEnabled = true;
            cmpCustomer.Location = new Point(269, 42);
            cmpCustomer.Name = "cmpCustomer";
            cmpCustomer.Size = new Size(366, 42);
            cmpCustomer.TabIndex = 25;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Crimson;
            btnCancle.Cursor = Cursors.Hand;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancle.ForeColor = Color.WhiteSmoke;
            btnCancle.Location = new Point(455, 308);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(180, 50);
            btnCancle.TabIndex = 22;
            btnCancle.Text = "الغاء";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(269, 308);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 50);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(646, 96);
            label4.Name = "label4";
            label4.Size = new Size(82, 34);
            label4.TabIndex = 20;
            label4.Text = "اسم المنتج";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(659, 195);
            label3.Name = "label3";
            label3.Size = new Size(52, 34);
            label3.TabIndex = 19;
            label3.Text = "السعر";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(269, 195);
            numPrice.Margin = new Padding(3, 10, 3, 10);
            numPrice.Maximum = new decimal(new int[] { 708119160, 23257, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(366, 41);
            numPrice.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(646, 46);
            label2.Name = "label2";
            label2.Size = new Size(82, 34);
            label2.TabIndex = 17;
            label2.Text = "اسم العميل";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 53);
            label1.TabIndex = 16;
            label1.Text = "تعديل فاتورة";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(269, 96);
            txtProduct.Margin = new Padding(3, 4, 3, 4);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(366, 41);
            txtProduct.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(659, 252);
            label6.Name = "label6";
            label6.Size = new Size(52, 34);
            label6.TabIndex = 28;
            label6.Text = "الكمية";
            // 
            // numQty
            // 
            numQty.Location = new Point(269, 250);
            numQty.Margin = new Padding(3, 14, 3, 14);
            numQty.Maximum = new decimal(new int[] { 1336347351, 232807, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(366, 41);
            numQty.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(659, 150);
            label5.Name = "label5";
            label5.Size = new Size(57, 34);
            label5.TabIndex = 24;
            label5.Text = "التاريخ";
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Simplified Arabic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtDate.Location = new Point(269, 150);
            dtDate.Name = "dtDate";
            dtDate.RightToLeft = RightToLeft.No;
            dtDate.Size = new Size(366, 41);
            dtDate.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(95, 68, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 71);
            panel1.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(txtProduct);
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numQty);
            groupBox1.Controls.Add(cmpCustomer);
            groupBox1.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(129, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 418);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "تعديل فاتورة";
            // 
            // EditInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1005, 597);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Simplified Arabic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += EditInvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmpCustomer;
        private Button btnCancle;
        private Button btnEdit;
        private Label label4;
        private Label label3;
        private NumericUpDown numPrice;
        private Label label2;
        private Label label1;
        private TextBox txtProduct;
        private Label label6;
        private NumericUpDown numQty;
        private Label label5;
        private DateTimePicker dtDate;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}