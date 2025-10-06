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

namespace DebtsManagementSystem.Forms.InvoiceForms
{
    public partial class AddInvoiceForm : Form
    {
        
        private readonly CustomerService _customerService = new CustomerService();
        private readonly InvoiceService _invoiceService = new InvoiceService();
        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        private void AddInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            cmpCustomer.DataSource = _customerService.GetAll();
            cmpCustomer.DisplayMember = "Name";
            cmpCustomer.ValueMember = "ID";
            SetupCombobox();
        }
        private void SetupCombobox()
        {
            cmpCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmpCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmpCustomer.SelectedValue==null || string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("الرجاء ادخال جميع البيانات المطلوبة");
                return;
            }
            var customer = cmpCustomer.SelectedItem as Customer;
            if (customer==null)
            {
                MessageBox.Show("العميل او الشركه غير موجود");
                return;
            }
            int customerId =customer.ID;
            string prductName = txtProduct.Text.Trim();
            int qty =(int) numQty.Value;
            decimal price = numPrice.Value;
            decimal total = qty * price;
           
            if (_invoiceService.AddCustomerInvoice(customerId, prductName, qty, price,DateTime.Now))
                MessageBox.Show($" تمت اضافة الفاتورة للعميل {customer.Name} بنجاح ");
            else
                MessageBox.Show($" لم يتم اضافه الفاتورة ");
            this.Close();
            new InvoiceForm().Show();
                       
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
