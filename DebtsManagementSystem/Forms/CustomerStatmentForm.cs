using DebtsManagementSystem.Data;
using DebtsManagementSystem.Services;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DebtsManagementSystem.Models;
using Rectangle = iTextSharp.text.Rectangle;


namespace DebtsManagementSystem.Forms
{
    public partial class CustomerStatmentForm : Form
    {
       
        private readonly CustomerService _customerService = new CustomerService();
        public CustomerStatmentForm()
        {
            InitializeComponent();
        }
        private void CustomerStatmentForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            dgvStatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void LoadCustomer()
        {
            var customers = _customerService.GetAll();
            cmpCustomer.DataSource = customers;
            cmpCustomer.DisplayMember = "Name";
            cmpCustomer.ValueMember = "ID";
        }
        void SetupDgvHeader()
        {
            dgvStatment.Columns["Date"].HeaderText = "التاريخ";
            dgvStatment.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvStatment.Columns["Description"].HeaderText = "الوصف";
            if (dgvStatment.Columns["InvoiceNo"] != null)
            {
                dgvStatment.Columns["InvoiceNo"].HeaderText = "رقم الفاتوره";
            }
          
            dgvStatment.Columns["Debt"].HeaderText = "مدين";
            dgvStatment.Columns["Debt"].DefaultCellStyle.Format="N0";
            dgvStatment.Columns["Credit"].HeaderText = "دائن";
            dgvStatment.Columns["Credit"].DefaultCellStyle.Format = "N0";
            dgvStatment.Columns["Balance"].HeaderText = "الرصيد";
            dgvStatment.Columns["Balance"].DefaultCellStyle.Format = "N0";
            dgvStatment.Columns["TransactionNo"].HeaderText = "رقم العملية";
        }
       
        private void ExportCustomerStatementToPdf(DataGridView dgv, string customerName)
        {
            // مسار حفظ الملف (الاسم يتغير حسب العميل)
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"كشف حساب العميل {customerName}.pdf");

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                // إنشاء المستند
                Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 30f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                // تحميل خط Simplified Arabic
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                iTextSharp.text.Font cellFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // 🔹 إضافة عنوان رئيسي باسم العميل
                PdfPTable headerTable = new PdfPTable(1);
                headerTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                PdfPCell hcell = new PdfPCell(new Phrase(customerName, titleFont));
                hcell.HorizontalAlignment = Element.ALIGN_CENTER;
                hcell.Border = Rectangle.NO_BORDER;
                headerTable.AddCell(hcell);
                pdfDoc.Add(headerTable);


                // إنشاء جدول بنفس عدد أعمدة الـ DataGridView
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                pdfTable.WidthPercentage = 100;

                // 🔹 إضافة رؤوس الأعمدة بخلفية ملونة
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new BaseColor(52, 152, 219); // أزرق جميل
                    headerCell.Padding = 5;
                    pdfTable.AddCell(headerCell);
                }

                // 🔹 إضافة الصفوف
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string text = cell.Value?.ToString() ?? "";
                            PdfPCell dataCell = new PdfPCell(new Phrase(text, cellFont));
                            dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            dataCell.Padding = 5;
                            pdfTable.AddCell(dataCell);
                        }
                    }
                }

                // 🔹 حساب المجموع وإضافته كسطر في النهاية (اختياري)
                if (dgv.Columns.Contains("Amount"))
                {
                    decimal total = 0;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["Amount"].Value != null)
                            total += Convert.ToDecimal(row.Cells["Amount"].Value);
                    }

                    PdfPCell totalCell = new PdfPCell(new Phrase($"إجمالي المبلغ: {total:N2}", headerFont));
                    totalCell.Colspan = dgv.ColumnCount;
                    totalCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    totalCell.BackgroundColor = new BaseColor(46, 204, 113); // أخضر فاتح
                    totalCell.Padding = 7;
                    pdfTable.AddCell(totalCell);
                }

                // إضافة الجدول للمستند
                pdfDoc.Add(pdfTable);

                pdfDoc.Close();
                writer.Close();
                stream.Close();
            }

            MessageBox.Show($"تم إنشاء الملف بنجاح باسم:\nكشف حساب العميل {customerName}.pdf",
                            "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnExportAsPdf_Click(object sender, EventArgs e)
        {
            var customrt = (Customer)cmpCustomer.SelectedItem;
            ExportCustomerStatementToPdf(dgvStatment, customrt.Name);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int customerId = (int)cmpCustomer.SelectedValue;
            var customer = _customerService.GetById(customerId);
            if (customer != null)
            {
                if (customer.IsSupplier)
                {
                    var compStatment = _customerService.GetCompanyStatment(customer.ID,dtStart.Value,dtEnd.Value);
                    dgvStatment.DataSource = compStatment;
                    if (compStatment.Any())
                    {
                        var lastBalance = compStatment.Last().Balance;
                        txtBalance.Text = lastBalance.ToString();
                        txtSataus.Text = lastBalance > 0 ? "مدين" : lastBalance < 0 ? "دائن" : "مسدد بالكامل";
                    }
                    SetupDgvHeader();
                }
                else
                {
                    var statment = _customerService.GetCustomerSatament(customerId,dtStart.Value, dtEnd.Value);
                    dgvStatment.DataSource = statment;
                    if (statment.Any())
                    {
                        var lastBalance = statment.Last().Balance;
                        txtBalance.Text = lastBalance.ToString();
                        txtSataus.Text = lastBalance > 0 ? "مدين" : lastBalance < 0 ? "دائن" : "مسدد بالكامل";
                    }
                    SetupDgvHeader();
                }
            }
        }
    }
}

