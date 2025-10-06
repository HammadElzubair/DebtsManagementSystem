namespace DebtsManagementSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenuStrip = new MenuStrip();
            العملاءToolStripMenuItem = new ToolStripMenuItem();
            ادارةالعملاءToolStripMenuItem = new ToolStripMenuItem();
            كشفحسابعميلToolStripMenuItem = new ToolStripMenuItem();
            الفواتيرToolStripMenuItem = new ToolStripMenuItem();
            اضافةفاتورةToolStripMenuItem = new ToolStripMenuItem();
            عرضالمديونياتToolStripMenuItem = new ToolStripMenuItem();
            ادارهالسداداتToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            mainMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            resources.ApplyResources(mainMenuStrip, "mainMenuStrip");
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { العملاءToolStripMenuItem, الفواتيرToolStripMenuItem, ادارهالسداداتToolStripMenuItem });
            mainMenuStrip.Name = "mainMenuStrip";
            // 
            // العملاءToolStripMenuItem
            // 
            resources.ApplyResources(العملاءToolStripMenuItem, "العملاءToolStripMenuItem");
            العملاءToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ادارةالعملاءToolStripMenuItem, كشفحسابعميلToolStripMenuItem });
            العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            // 
            // ادارةالعملاءToolStripMenuItem
            // 
            resources.ApplyResources(ادارةالعملاءToolStripMenuItem, "ادارةالعملاءToolStripMenuItem");
            ادارةالعملاءToolStripMenuItem.Name = "ادارةالعملاءToolStripMenuItem";
            ادارةالعملاءToolStripMenuItem.Click += ادارةالعملاءToolStripMenuItem_Click;
            // 
            // كشفحسابعميلToolStripMenuItem
            // 
            resources.ApplyResources(كشفحسابعميلToolStripMenuItem, "كشفحسابعميلToolStripMenuItem");
            كشفحسابعميلToolStripMenuItem.Name = "كشفحسابعميلToolStripMenuItem";
            كشفحسابعميلToolStripMenuItem.Click += كشفحسابعميلToolStripMenuItem_Click;
            // 
            // الفواتيرToolStripMenuItem
            // 
            resources.ApplyResources(الفواتيرToolStripMenuItem, "الفواتيرToolStripMenuItem");
            الفواتيرToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { اضافةفاتورةToolStripMenuItem, عرضالمديونياتToolStripMenuItem });
            الفواتيرToolStripMenuItem.Name = "الفواتيرToolStripMenuItem";
            // 
            // اضافةفاتورةToolStripMenuItem
            // 
            resources.ApplyResources(اضافةفاتورةToolStripMenuItem, "اضافةفاتورةToolStripMenuItem");
            اضافةفاتورةToolStripMenuItem.Name = "اضافةفاتورةToolStripMenuItem";
            اضافةفاتورةToolStripMenuItem.Click += اضافةفاتورةToolStripMenuItem_Click;
            // 
            // عرضالمديونياتToolStripMenuItem
            // 
            resources.ApplyResources(عرضالمديونياتToolStripMenuItem, "عرضالمديونياتToolStripMenuItem");
            عرضالمديونياتToolStripMenuItem.Name = "عرضالمديونياتToolStripMenuItem";
            عرضالمديونياتToolStripMenuItem.Click += عرضالمديونياتToolStripMenuItem_Click;
            // 
            // ادارهالسداداتToolStripMenuItem
            // 
            resources.ApplyResources(ادارهالسداداتToolStripMenuItem, "ادارهالسداداتToolStripMenuItem");
            ادارهالسداداتToolStripMenuItem.Name = "ادارهالسداداتToolStripMenuItem";
            ادارهالسداداتToolStripMenuItem.Click += ادارهالسداداتToolStripMenuItem_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.ControlLight;
            label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panel1);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem العملاءToolStripMenuItem;
        private ToolStripMenuItem ادارةالعملاءToolStripMenuItem;
        private ToolStripMenuItem الفواتيرToolStripMenuItem;
        private ToolStripMenuItem اضافةفاتورةToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem عرضالمديونياتToolStripMenuItem;
        private ToolStripMenuItem كشفحسابعميلToolStripMenuItem;
        private ToolStripMenuItem ادارهالسداداتToolStripMenuItem;
        private Label label1;
    }
}