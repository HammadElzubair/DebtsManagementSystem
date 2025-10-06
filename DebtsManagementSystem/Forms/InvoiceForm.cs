using DebtsManagementSystem.Data;
using DebtsManagementSystem.Forms.InvoiceForms;
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
    public partial class InvoiceForm : Form
    {

        private readonly ReportService _reportService = new ReportService();
        private readonly PaymentService _paymentService = new PaymentService();
        private readonly InvoiceService _invoiceService = new InvoiceService();
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoice.EnableHeadersVisualStyles = false;

            dgvInvoice.RowsDefaultCellStyle.BackColor = Color.White;
            dgvInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            LoadInvoice();
            SetupDgv();
        }
        private void SetupDgv()
        {
            dgvInvoice.Columns["Id"].HeaderText = "رقم الفاتوره";
            dgvInvoice.Columns["CustomerId"].HeaderText = "رقم العميل";
            dgvInvoice.Columns["CustomerName"].HeaderText = "اسم العميل";
            dgvInvoice.Columns["ProductName"].HeaderText = "اسم المنتج";
            dgvInvoice.Columns["Quantity"].HeaderText = "الكمية";
            dgvInvoice.Columns["Price"].HeaderText = "السعر";
            dgvInvoice.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvInvoice.Columns["Total"].HeaderText = "الاجمالي";
            dgvInvoice.Columns["Total"].DefaultCellStyle.Format = "N0";
            dgvInvoice.Columns["Balance"].HeaderText = "الرصيد";
            dgvInvoice.Columns["Balance"].DefaultCellStyle.Format = "N0";
            dgvInvoice.Columns["Date"].HeaderText = "تاريخ الفاتورة";
            dgvInvoice.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvInvoice.Columns["Status"].HeaderText = "الحالة";

        }
        private void LoadInvoice()
        {
            dgvInvoice.DataSource = _reportService.GetAllInvoiceWithCustomerBalance();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];
                int invoiceId = (int)row.Cells["Id"].Value;
                var invoice = _invoiceService.GetById(invoiceId);
                if (invoice != null)
                {
                    var form = new PaymentForm(invoice);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadInvoice();
                    }
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow == null)
                MessageBox.Show("الرجاء اختيار فاتوره للتعديل");
            int invoiceId = (int)dgvInvoice.CurrentRow.Cells["Id"].Value;
            var form = new EditInvoiceForm(invoiceId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadInvoice();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow != null)
            {
                int invoiceId = (int)dgvInvoice.CurrentRow.Cells["Id"].Value;
                var result = MessageBox.Show("هل ترغب في حذف الفاتورة؟", "تاكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_invoiceService.DeleteCustomerInvoice(invoiceId))
                {

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(" تم حذف الفاتورة وخصم المبلغ من رصيد العميل");
                        LoadInvoice();
                    }

                }
                else
                    MessageBox.Show(" لم يتم الحذف");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var data = _reportService.GetAllInvoiceWithCustomerBalance(dtStart.Value, dtEnd.Value);
            if (data != null && data.Count > 0)
            {
                dgvInvoice.DataSource = data;
                SetupDgv();
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لعرضها تحقق من التاريخ");
                dgvInvoice.DataSource = null;
            }
            dgvInvoice.Refresh();
        }

        private void btnNewInvoiceForm_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddInvoiceForm().Show();
        }

     
    }
}
