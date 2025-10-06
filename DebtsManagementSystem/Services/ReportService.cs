using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;

public class ReportService
{
    AppDbContext _context=DbContextFactory.context;
    public ReportService()
    {

    }

    public object GetCustomerReport(int customerId)
    {
        var customer = _context.Customers
            .Where(c => c.ID == customerId && c.IsSupplier == false)
            .Select(c => new
            {
                c.Name,
                c.Balance,
                Invoices = c.Invoices.Select(i => new
                {
                    i.ProductName,
                    i.Quantity,
                    i.Price,
                    i.Total,
                    i.Date
                }).ToList(),
                Payments = c.Payments.Select(p => new
                {
                    p.TransactionNumber,
                    p.Amount,
                    p.Date
                }).ToList()
            })
            .FirstOrDefault();

        return customer;
    }

    public object GetCompanyReport(int compId)
    {
        var company = _context.Customers.Find(compId);
        if (company == null) return null;

        return new
        {
            company.Name,
            company.Balance,
            Invoices = _context.Invoices.Where(i => i.Id==compId).ToList(),
            Payments = _context.CompanyPayments.ToList()
        };
    }
    public List<object> GetAllInvoiceWithCustomerBalance(DateTime? startDate = null, DateTime? endDate = null)
    {
        var result = _context.Invoices.Include(i=>i.Customer).Select(i => new
        {
            Id = i.Id,
            CustomerId = i.CustomerId,
            CustomerName = i.Customer.Name,
            ProductName = i.ProductName,
            Quantity = i.Quantity,
            Price = i.Price,
            Total = i.Total,
            Balance = i.Customer.Balance,
            Date = i.Date,
            Status = i.Customer.Status
        });
        if (startDate.HasValue && endDate.HasValue)
        {
            result = result.Where(i => i.Date >= startDate.Value && i.Date <= endDate.Value).OrderBy(i => i.Date);
        }
        else
        {
            result = result.OrderBy(i => i.Date).Take(30).OrderBy(i => i.Date);
        }
        return result.ToList<object>();
    }
}

