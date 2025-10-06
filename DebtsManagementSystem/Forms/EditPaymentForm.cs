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
    public partial class EditPaymentForm : Form
    {

        private readonly PaymentService _paymentService = new PaymentService();
        private readonly CustomerService _customerService = new CustomerService();
        //
        int _paymentId, _customerId;
        public EditPaymentForm(int customerId, int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
            _customerId = customerId;
        }

        private void EditPaymentForm_Load(object sender, EventArgs e)
        {
            var customer = _customerService.GetById(_customerId);
            if (customer != null && customer.IsSupplier)
            {
                var payment = _paymentService.GetCompanyPaymentById(_paymentId);
                txtCustomerName.Text = customer.Name.ToString();
                txtAmount.Text = payment.Amount.ToString();
                txtTransactionNo.Text = payment.TransactionNumber.ToString();
                txtNote.Text = payment.Note.ToString();
                dtPaymentDate.Value = payment.Date;
            }
            else
            {
                var payment = _paymentService.GetCustomerPaymentById(_paymentId);
                txtCustomerName.Text = customer.Name.ToString();
                txtAmount.Text = payment.Amount.ToString();
                txtTransactionNo.Text = payment.TransactionNumber.ToString();
                txtNote.Text = payment.Note.ToString();
                dtPaymentDate.Value = payment.Date;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int customerId = _customerId;
            decimal amount = decimal.Parse(txtAmount.Text);
            DateTime date = dtPaymentDate.Value;
            string note = txtNote.Text.ToString();
            if (_paymentService.EditCustomerPayment(_paymentId, amount, date, note))
            {
                MessageBox.Show("تم التعديل بنجاح");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

       
    }
}
