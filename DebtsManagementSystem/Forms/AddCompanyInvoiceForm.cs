using DebtsManagementSystem.Data;
using DebtsManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtsManagementSystem.Forms
{
    public partial class AddCompanyInvoiceForm : Form
    {
      
        CustomerService CustomerService = new CustomerService();
        public AddCompanyInvoiceForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string procut = txtProduct.Text.Trim();
            int qty = (int)numQty.Value;
            decimal price = (int)numPrice.Value;
        }

        private void AddCompanyInvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
