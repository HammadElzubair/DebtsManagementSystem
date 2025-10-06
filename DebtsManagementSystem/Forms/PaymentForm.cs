using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DebtsManagementSystem.Services;
using DocumentFormat.OpenXml.Packaging;
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
    public partial class PaymentForm : Form
    {
       
        private readonly CustomerService _customerService = new CustomerService();
        private readonly PaymentService _paymentService = new PaymentService();
        private readonly InvoiceService _invoiceService = new  InvoiceService();
        private readonly CompanyService _companyService = new CompanyService();
        Invoice _invoice;
        public PaymentForm(Invoice invoice)
        {
            _invoice = invoice;
            InitializeComponent();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(cmpInvoice.SelectedValue==null || string.IsNullOrWhiteSpace(txtBankNo.Text))
            {
                MessageBox.Show("الرجاء ادخال كل البيانات المطلوبة");
                return;
            }
            string bankNo = txtBankNo.Text.Trim();
            decimal amount = numAmount.Value;
            int invoiceId = _invoice.Id;
            int customerId = _invoice.CustomerId;
            DateTime date = dtPaymentDate.Value;
            string note = txtNote.Text.Trim();
            var selectedCustomer = (Customer)cmpCustomer.SelectedItem;


            if (selectedCustomer.IsSupplier)
            {
                if(_paymentService.AddCompanyPayment(customerId, bankNo, amount, date,note))
                {
                     MessageBox.Show(" تم سداد المبلغ في رصيد الشركة");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                 
                else
                {
                    MessageBox.Show("رقم العميلة مرفوض تم السداد به مسبقا");
                }
                this.Close();
                new ManagePaymentsForm().Show();
            }
            else
            {
                if (_paymentService.AddCustomerPayment(customerId, bankNo, amount, date,note))
                {
                    MessageBox.Show(" تم سداد المبلغ");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("لم يتم السداد تحقق من رقم العملية");
            }
           
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadProductName();
            cmpCustomer.SelectedValue = _invoice.CustomerId;
            cmpInvoice.SelectedValue = _invoice.Id;
           
        }
        private void LoadCustomer()
        {
            cmpCustomer.DataSource = _customerService.GetAll();
            cmpCustomer.DisplayMember = "Name";
            cmpCustomer.ValueMember = "ID";
            cmpCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmpCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadProductName()
        {
            cmpInvoice.DataSource = _invoiceService.GetAll();       
            cmpInvoice.DisplayMember = "ProductName";
            cmpInvoice.ValueMember = "Id";
        }
      
    }
}
