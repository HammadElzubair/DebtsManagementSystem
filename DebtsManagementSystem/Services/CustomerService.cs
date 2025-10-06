using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DebtsManagementSystem.Models.DTOs;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Services
{
    public class CustomerService
    {
        AppDbContext _context = DbContextFactory.context;
        public CustomerService()
        {

        }

        public List<Customer> GetAll() => _context.Customers.ToList();

        public bool Add(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return true;
        }

        public void Update(Customer c)
        {
            _context.Customers.Update(c);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = _context.Customers.Find(id);
            if (c != null)
            {
                _context.Customers.Remove(c);
                _context.SaveChanges();
            }
        }
        public Customer GetById(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            return customer;
        }
        public List<CompanyStatmentDto> GetCompanyStatment(int compId,DateTime?startDate=null,DateTime?endDate=null)
        {
            var invoice = _context.Invoices.Where(i => i.CustomerId == compId).ToList().Select(i => new CompanyStatmentDto
            {
                Date = i.Date,
                Description = "# فاتورة شراء" + i.Id,
                InvoiceNo = i.Id.ToString(),
                Debt = i.Total,
                Credit = 0,
                TransactionNo = null
            });

            var payment = _context.CompanyPayments.ToList().Select(p => new CompanyStatmentDto
            {
                Date = p.Date,
                Description = "# سداد للشركة",
                InvoiceNo = null,
                Debt = 0,
                Credit = p.Amount,
                TransactionNo = p.TransactionNumber
                
            });
            if (startDate.HasValue && endDate.HasValue)
            {
                invoice = invoice.Where(i => i.Date >= startDate.Value && i.Date <= endDate.Value);
                payment = payment.Where(p => p.Date >= startDate.Value && p.Date <= endDate.Value);
            }
            var all = invoice.Concat(payment).OrderBy(x => x.Date).ToList();
            decimal ruuingBalance = 0;
            foreach (var item in all)
            {
                ruuingBalance -= item.Debt - item.Credit;
                item.Balance = ruuingBalance;
            }
            return all;
        }
        public List<StatmentDto> GetCustomerSatament(int customerId,DateTime? startDate = null, DateTime? endDate = null)
        {
            var invoice = _context.Invoices.Where(i => i.CustomerId == customerId && i.Customer.IsSupplier == false).ToList().Select(i => new StatmentDto
            {
                Date = i.Date,
                Description = "# فاتورة " + i.Id,
                Debt = i.Total,
                Credit = 0
            });
            var paymet = _context.Payments.Where(p => p.CustomerId == customerId).ToList().Select(p => new StatmentDto
            {
                Date = p.Date,
                Description = "# سداد " + p.Id,
                Debt = 0,
                Credit = p.Amount,
                TransactionNo = p.TransactionNumber
            });
            if (startDate.HasValue && endDate.HasValue)
            {
                invoice = invoice.Where(i => i.Date >= startDate.Value && i.Date <= endDate.Value);
                paymet = paymet.Where(p => p.Date >= startDate.Value && p.Date <= endDate.Value);
            }
            var statment = invoice.Union(paymet).OrderBy(s => s.Date).ToList();
            decimal balance = 0;
            foreach (var s in statment)
            {
                balance += (s.Debt - s.Credit);
                s.Balance = balance;
            }
            return statment;
        }
    }
}
