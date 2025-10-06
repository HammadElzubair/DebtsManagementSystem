using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtsManagementSystem.Forms;
using DebtsManagementSystem.Forms.InvoiceForms;
using DebtsManagementSystem.Models;
namespace DebtsManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomrtForm().Show();
        }
        private void اضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddInvoiceForm().Show();
        }
        private void عرضالمديونياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InvoiceForm().Show();
        }
        private void كشفحسابعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerStatmentForm().Show();
        }

        private void ادارهالسداداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManagePaymentsForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


       
    }


}
