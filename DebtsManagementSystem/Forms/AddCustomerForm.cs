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
    public partial class AddCustomerForm : Form
    {
       
        private readonly CustomerService _customerService = new CustomerService();
        public AddCustomerForm()
        {
            this.InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            Customer customer = new Customer { Name = name, IsSupplier = chkIsSupplier.Checked };
            if (_customerService.Add(customer))
            {
                MessageBox.Show("تمت اضافه العميل بنجاح");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("حدث خطا لم تتم الاضافة");


        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
