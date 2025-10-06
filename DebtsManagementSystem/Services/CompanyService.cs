using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DebtsManagementSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Services
{
    public class CompanyService
    {
          AppDbContext _db = DbContextFactory.context;

        public List<CompanyStatmentDto> GetCompanyStatment(int compId)
        {
            var invoice = _db.Invoices.Where(i => i.CustomerId==compId).ToList().Select(i => new CompanyStatmentDto
            {
                Date = i.Date,
                Description = "# فاتورة شراء" + i.Id,
                InvoiceNo = i.Id.ToString(),
                Debt = i.Total,
                Credit = 0,
                TransactionNo = null
            });

            var payment = _db.CompanyPayments.ToList().Select(p => new CompanyStatmentDto
            {
                Date = p.Date,
                Description = "# سداد للشركة",
                InvoiceNo = null,
                Debt = 0,
                Credit = p.Amount,
                TransactionNo = p.TransactionNumber
            });
            var all = invoice.Concat(payment).OrderBy(x => x.Date).ToList();
            decimal ruuingBalance = 0;
            foreach (var item in all)
            {
                ruuingBalance -= item.Debt - item.Credit;
                item.Balance = ruuingBalance;
            }
            return all;
        }
    }
}
