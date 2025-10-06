using DebtsManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Services
{
    public class BalanceHelper
    {
        private readonly AppDbContext _context;
        public BalanceHelper(AppDbContext context) => _context = context;

        /// <summary>
        /// يعيد حساب رصيد العميل/المورد ويخزنه في حقل Customer.Balance.
        /// يعيد القيمة المحدثة.
        /// </summary>
        public decimal RecalculateAndSetBalance(int? customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.ID == customerId);
            if (customer == null) throw new ArgumentException("Customer not found", nameof(customerId));

            var invoicesTotal = _context.Invoices
                .Where(i => i.CustomerId == customerId)
                .Select(i => (decimal?)i.Total)
                .Sum() ?? 0m;

            decimal paymentsTotal;
            if (customer.IsSupplier)
            {
               paymentsTotal = _context.CompanyPayments
                   .Where(p => p.CustomerId == customerId)
                   .Select(p => (decimal?)p.Amount)
                   .Sum() ?? 0m;
               
            }
            else
            {
                paymentsTotal = _context.Payments
                    .Where(p => p.CustomerId == customerId)
                    .Select(p => (decimal?)p.Amount)
                    .Sum() ?? 0m;
               
            }
                var net = invoicesTotal - paymentsTotal;
            if (customer.IsSupplier) net = -net; // suppliers' balance stored as negative

            customer.Balance = Math.Round(net, 2);
            _context.SaveChanges();
            return customer.Balance;
        }
        /// <summary>
        /// حساب الرصيد حتى تاريخ (غير شامل) لاستخدامه كرصيد افتتاحي في تقارير الكشوف.
        /// </summary>
        public decimal GetOpeningBalance(int customerId, DateTime upToExclusive)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.ID == customerId);
            if (customer == null) throw new ArgumentException("Customer not found", nameof(customerId));

            var invoicesTotal = _context.Invoices
                .Where(i => i.CustomerId == customerId && i.Date < upToExclusive)
                .Select(i => (decimal?)i.Total)
                .Sum() ?? 0m;

            var paymentsTotal = _context.Payments
                .Where(p => p.CustomerId == customerId && p.Date < upToExclusive)
                .Select(p => (decimal?)p.Amount)
                .Sum() ?? 0m;

            var net = invoicesTotal - paymentsTotal;
            if (customer.IsSupplier) net = -net;
            return Math.Round(net, 2);
        }
    }
}