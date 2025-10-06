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
    public partial class CustomrtForm : Form
    {
    
        private readonly CustomerService _customerService = new CustomerService();
        public CustomrtForm()
        {
            InitializeComponent();
        }
        private void CustomrtForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadCustomer();
            dgvCustomer.Columns["ID"].HeaderText = "الرقم";
            dgvCustomer.Columns["Name"].HeaderText = "الاسم";
            dgvCustomer.Columns["Balance"].HeaderText = "الرصيد";
            dgvCustomer.Columns["Status"].HeaderText = "الحالة";
            dgvCustomer.Columns["IsSupplier"].HeaderText = "شركه";
            //hide invoide column
            dgvCustomer.Columns["Invoices"].Visible =false;
            dgvCustomer.Columns["Payments"].Visible =false;
        }
        private void LoadCustomer()
        {
            dgvCustomer.DataSource = _customerService.GetAll();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addCustomr = new AddCustomerForm();
            if (addCustomr.ShowDialog() == DialogResult.OK)
            {
                LoadCustomer();
            }
        }
    }
}
