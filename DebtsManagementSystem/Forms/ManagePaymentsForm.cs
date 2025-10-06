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
    public partial class ManagePaymentsForm : Form
    {
       
        private readonly CustomerService _customerService = new CustomerService();
        private readonly PaymentService _paymentService = new PaymentService();
        public ManagePaymentsForm()
        {
            InitializeComponent();
        }

        private void ManagePaymentsForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadCustomer()
        {
            var customers = _customerService.GetAll();
            cmpCustomer.DataSource = customers;
            cmpCustomer.DisplayMember = "Name";
            cmpCustomer.ValueMember = "ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmpCustomer.SelectedItem != null)
            {
                var customer = (Customer)cmpCustomer.SelectedItem;
                if (customer != null)
                {
                    if (customer.IsSupplier)
                    {
                        dgvPayments.DataSource = GetCompanyPayment();
                        SetUpDgvForCompanyPayment();
                    }
                    else
                    {
                        dgvPayments.DataSource = GetCustomerPayment(customer.ID);
                        SetUpDgvForCustomerPayment();
                    }

                }
                else
                    MessageBox.Show("العميل غير موجود");
            }
            else
                MessageBox.Show("الرجاء اختيار عميل لعرض السدادات");
        }

        private void SetUpDgvForCustomerPayment()
        {
            dgvPayments.Columns["Id"].HeaderText = "رقم السداد";
            dgvPayments.Columns["CustomerId"].HeaderText = "رقم العميل";
            dgvPayments.Columns["Customer"].Visible = false;
            dgvPayments.Columns["TransactionNumber"].HeaderText = "رقم العملية";
            dgvPayments.Columns["Amount"].HeaderText = "المبلغ";
            dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "N02";
            dgvPayments.Columns["Date"].HeaderText = "التاريخ";
            dgvPayments.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPayments.Columns["Note"].HeaderText = "ملاحظات";

        }
        private void SetUpDgvForCompanyPayment()
        {
            dgvPayments.Columns["Id"].HeaderText = "رقم السداد";
            dgvPayments.Columns["CustomerId"].Visible=false;
            dgvPayments.Columns["Amount"].HeaderText = "المبلغ";
            dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "N02";
            dgvPayments.Columns["TransactionNumber"].HeaderText = "رقم العملية";
            dgvPayments.Columns["Date"].HeaderText = "التاريخ";
            dgvPayments.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPayments.Columns["Note"].HeaderText = "ملاحظات";
        }


        private List<Payment> GetCustomerPayment(int id)
        {
            return _paymentService.GetCustomerPayment(id);
        }
        private List<CompanyPayment> GetCompanyPayment()
        {
            return _paymentService.GetCompanyPayment();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int paymentId = (int)dgvPayments.CurrentRow.Cells["Id"].Value;
            if (dgvPayments.CurrentRow != null)
            {
                var customer = (Customer)cmpCustomer.SelectedItem;

                var form = new EditPaymentForm(customer.ID, paymentId);
                if (form.ShowDialog() == DialogResult.OK)
                    this.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvPayments.CurrentRow!=null)
            {
                int paymentId = (int)dgvPayments.CurrentRow.Cells["Id"].Value;
                var customer = cmpCustomer.SelectedItem as Customer;
                if(customer.IsSupplier)
                {
                   if( _paymentService.DeleteCompanyPayment(paymentId))
                    MessageBox.Show("تم حذف سداد الشركه");
                    dgvPayments.DataSource = _paymentService.GetCompanyPayment();
                }
                else
                {
                    if(_paymentService.DeleteCustomerPayment(paymentId))
                        MessageBox.Show("تم حذف سداد العميل");
                    dgvPayments.DataSource = _paymentService.GetAllCustomerPayment();
                }
            }
        }
    }
}
