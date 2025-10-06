using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
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
    public partial class EditInvoiceForm : Form
    {
       
        private readonly InvoiceService _invoiceService = new InvoiceService();
        private readonly CustomerService _customerService = new CustomerService();
        private readonly int _invoiceId;
        private Invoice _invoice;
        public EditInvoiceForm(int invoiceId)
        {
            _invoiceId = invoiceId;
            InitializeComponent();
        }
        private void EditInvoiceForm_Load(object sender, EventArgs e)
        {
            _invoice = _invoiceService.GetById(_invoiceId);
            if (_invoice != null)
            {
                var customer = _customerService.GetById(_invoice.CustomerId);
                cmpCustomer.Text = customer.Name.ToString();
                txtProduct.Text = _invoice.ProductName;
                numPrice.Value = _invoice.Price;
                numQty.Value = _invoice.Quantity;
                dtDate.Value = _invoice.Date;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int invoiceId = _invoice.Id;
            int customerId = _invoice.CustomerId;
            int qty = (int)numQty.Value;
            string product = txtProduct.Text;
            decimal price = (decimal)numPrice.Value;
            DateTime date = dtDate.Value;
            if(_invoiceService.EditCustomerInvoice(invoiceId,qty,price,date))
            {
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("فشل التعديل");
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
