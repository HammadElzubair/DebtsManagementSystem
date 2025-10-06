namespace DebtsManagementSystem.Forms
{
    partial class AddCustomerForm
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
            txtName = new TextBox();
            btnAdd = new Button();
            chkIsSupplier = new CheckBox();
            panel2 = new Panel();
            label5 = new Label();
            groupBox1 = new GroupBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(441, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 47);
            label1.TabIndex = 0;
            label1.Text = "إضافه عميل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(663, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 34);
            label2.TabIndex = 1;
            label2.Text = "اسم العميل";
            // 
            // txtName
            // 
            txtName.Font = new Font("Simplified Arabic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(288, 68);
            txtName.Margin = new Padding(4, 6, 4, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(367, 47);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(95, 68, 204);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Simplified Arabic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(289, 120);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // chkIsSupplier
            // 
            chkIsSupplier.AutoSize = true;
            chkIsSupplier.Font = new Font("Simplified Arabic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkIsSupplier.Location = new Point(497, 120);
            chkIsSupplier.Name = "chkIsSupplier";
            chkIsSupplier.Size = new Size(158, 35);
            chkIsSupplier.TabIndex = 4;
            chkIsSupplier.Text = "هل هو مورد (شركه)";
            chkIsSupplier.UseVisualStyleBackColor = true;
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
            panel2.Size = new Size(1038, 73);
            panel2.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(1363, -19);
            label5.Name = "label5";
            label5.Size = new Size(149, 53);
            label5.TabIndex = 2;
            label5.Text = "إدارة الفواتير";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkIsSupplier);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(67, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 230);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "إضافه عميل جديد";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1038, 426);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Font = new Font("Simplified Arabic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "AddCustomerForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Load += AddCustomerForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnAdd;
        private CheckBox chkIsSupplier;
        private Panel panel2;
        private Label label5;
        private GroupBox groupBox1;
    }
}