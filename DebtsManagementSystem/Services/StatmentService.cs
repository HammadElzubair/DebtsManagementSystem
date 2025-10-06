using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models.DTOs;
using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Services
{
    public class StatmentService
    {
       AppDbContext _context =DbContextFactory.context;
        private readonly BalanceHelper _balanceHelper;
        public StatmentService()
        {
            _balanceHelper = new BalanceHelper(_context);
        }
      
        public class StatementRow
        {
            public DateTime Date { get; set; }
            public decimal Debt { get; set; } // فاتورة
            public decimal Credit { get; set; } // دفعة
            public decimal Balance { get; set; }
            public string Description { get; set; }
            public string TransactionNo { get; set; }
        }

        public IQueryable<StatementRow> GetFullStatementQuery(int customerId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var invoices = _context.Invoices
                .Where(i => i.CustomerId == customerId)
                .Select(i => new StatementRow
                {
                    Date = i.Date,
                    Debt = i.Total,
                    Credit = 0,
                    Description = i.ProductName ?? "Invoice",
                    TransactionNo = i.Id.ToString()
                });

            var payments = _context.Payments
                .Where(p => p.CustomerId == customerId)
                .Select(p => new StatementRow
                {
                    Date = p.Date,
                    Debt = 0,
                    Credit = p.Amount,
                    Description = p.Note ?? "Payment",
                    TransactionNo = p.TransactionNumber
                });

            var all = invoices.Concat(payments).AsQueryable();

            if (startDate.HasValue) all = all.Where(r => r.Date >= startDate.Value);
            if (endDate.HasValue) all = all.Where(r => r.Date <= endDate.Value);

            return all.OrderBy(r => r.Date);
        }

        public System.Collections.Generic.List<StatementRow> GetStatementWithRunningBalance(int customerId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var opening = startDate.HasValue ? _balanceHelper.GetOpeningBalance(customerId, startDate.Value) : _balanceHelper.RecalculateAndSetBalance(customerId);
            var rows = GetFullStatementQuery(customerId, startDate, endDate).ToList();

            decimal running = opening;
            foreach (var r in rows)
            {
                // ملاحظة: الصيغة التالية تفترض أن Debt يزيد الرصيد (عميل يدين لنا) وCredit ينقصه.
                running += (r.Debt - r.Credit);
                r.Balance = running;
            }

            // إذا أردت تضمين صف افتتاحي في رأس الكشف:
            // rows.Insert(0, new StatementRow { Date = startDate ?? DateTime.MinValue, Debt = 0, Credit = 0, Balance = opening, Description = "Opening Balance" });

            return rows;
        }
    }
    //    private AppDbContext _db = new AppDbContext();
    //    public List<StatmentDto> GetCustomerSatament(int customerId)
    //    {
    //        var invoice = _db.Invoices.Where(i => i.CustomerId == customerId && i.Customer.IsSupplier == false ).ToList().Select(i => new StatmentDto
    //        {
    //            Date = i.Date,
    //            Description = "# فاتورة " + i.Id,
    //            Debt = i.Total,
    //            Credit = 0
    //        });
    //        var paymet = _db.Payments.Where(p => p.CustomerId == customerId).ToList().Select(p => new StatmentDto
    //        {
    //            Date = p.Date,
    //            Description = "# سداد " + p.Id,
    //            Debt = 0,
    //            Credit = p.Amount,
    //            TransactionNo= p.TransactionNumber
    //        });
    //        var statment = invoice.Union(paymet).OrderBy(s => s.Date).ToList();
    //        decimal balance = 0;
    //        foreach (var s in statment)
    //        {
    //            balance += (s.Debt - s.Credit);
    //            s.Balance = balance;
    //        }
    //        return statment;
    //    }
}

