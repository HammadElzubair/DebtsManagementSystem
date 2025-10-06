using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DebtsManagementSystem.Services;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.EntityFrameworkCore;

public class InvoiceService
{
     AppDbContext _context =DbContextFactory.context;
    private readonly BalanceHelper _balanceHelper;

    public InvoiceService()
    {
        _balanceHelper = new BalanceHelper(_context);
    }

    public bool AddCustomerInvoice(int customerId, string productName, int qty, decimal price, DateTime date, string note = null)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var invoice = new Invoice
            {
                CustomerId = customerId,
                ProductName = productName,
                Quantity = qty,
                Price = price,
                Total = Math.Round(qty * price, 2),
                Date = date
            };

            _context.Invoices.Add(invoice);
            _context.SaveChanges();

            _balanceHelper.RecalculateAndSetBalance(customerId);

            tx.Commit();
            return true;
        }
        catch
        {
            tx.Rollback();
            throw;
        }
    }

    public bool EditCustomerInvoice(int invoiceId, int newQty, decimal newPrice, DateTime newDate, string newNote = null)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.Id == invoiceId);
            if (invoice == null) return false;

            invoice.Quantity = newQty;
            invoice.Price = newPrice;
            invoice.Total = Math.Round(newQty * newPrice, 2);
            invoice.Date = newDate;
            

            _context.Invoices.Update(invoice);
            _context.SaveChanges();

            _balanceHelper.RecalculateAndSetBalance(invoice.CustomerId);

            tx.Commit();
            return true;
        }
        catch
        {
            tx.Rollback();
            throw;
        }
    }

    public bool DeleteCustomerInvoice(int invoiceId)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.Id == invoiceId);
            if (invoice == null) return false;

            var customerId = invoice.CustomerId;
            _context.Invoices.Remove(invoice);
            _context.SaveChanges();

            _balanceHelper.RecalculateAndSetBalance(customerId);

            tx.Commit();
            return true;
        }
        catch
        {
            tx.Rollback();
            throw;
        }
    }
    public List<Invoice> GetAll()
    {
        return _context.Invoices.ToList();
    }
    public Invoice GetById(int id)
    {
        return _context.Invoices.FirstOrDefault(i => i.Id == id);
    }


    //public bool AddCustomerInvoice(int customerId, string product, int qty, decimal price)
    //{
    //    var invoice = new Invoice
    //    {
    //        CustomerId = customerId,
    //        ProductName = product,
    //        Quantity = qty,
    //        Price = price,
    //        Date = DateTime.Now,
    //        InvoiceType = InvoiceType.Sales,
    //        Total = qty*price

    //    };

    //     invoice.Customer = _context.Customers.Find(customerId);
    //    if (invoice.Customer != null)
    //    {
    //        invoice.Customer.Balance += invoice.Total; // زيادة المديونية
    //    }

    //    _context.Invoices.Add(invoice);
    //    _context.SaveChanges();
    //    return true;
    //}
    //public List<Invoice> GetAll()
    //{
    //    return _context.Invoices.ToList();
    //}
    //public Invoice GetById(int id)
    //{
    //    return _context.Invoices.FirstOrDefault(i=>i.Id == id);
    //}
    //public bool UpdateInvoice(int invoiceId,string product,int qty,decimal price,DateTime date)
    //{
    //    using var transaction = _context.Database.BeginTransaction();
    //    var invoice = _context.Invoices.Include(i => i.Customer).FirstOrDefault(i => i.Id == invoiceId);
    //    try
    //    {
    //        if (invoice == null)
    //            return false;
    //        var customer = invoice.Customer;
    //        if (customer == null)
    //            return false;

    //        decimal oldTotl = invoice.Total;
    //        //Update Invoice details
    //        invoice.ProductName = product;
    //        invoice.Quantity = qty;
    //        invoice.Price = price;
    //        invoice.Date = date;
    //        invoice.Total = qty * price;
    //        decimal newTotal = invoice.Total;
    //        if(invoice.Customer.IsSupplier)
    //        {
    //            invoice.Customer.Balance += oldTotl;
    //            invoice.Customer.Balance -= newTotal;
    //        }
    //        else
    //        {
    //            invoice.Customer.Balance -= oldTotl;
    //            invoice.Customer.Balance += newTotal;

    //        }
    //        _context.SaveChanges();
    //        transaction.Commit();
    //        return true;
    //    }
    //    catch
    //    {
    //        transaction.Rollback();
    //        return false;
    //    }
    //}
    //public bool AddCompanyInvoice(int compId, string product, int qty, decimal price)
    //{
    //    var invoice = new Invoice
    //    {
    //        CustomerId = compId,
    //        ProductName = product,
    //        Quantity = qty,
    //        Price = price,
    //        Date = DateTime.Now,
    //        InvoiceType = InvoiceType.Purchase,
    //        Total = (qty*price)

    //    };

    //    var customer = _context.Customers.Find(compId);
    //    if (customer != null)
    //    {
    //        customer.Balance -= invoice.Total; // زيادة المديونية
    //    }

    //    _context.Invoices.Add(invoice);
    //    _context.SaveChanges();
    //    return true;
    //}
    //public bool DeleteInvoice(int invId)
    //{
    //    var invoice = _context.Invoices.Include(i=>i.Customer).FirstOrDefault(i=>i.Id==invId);
    //    var customer = invoice.Customer;
    //    if(invoice!=null && customer!=null)
    //    {
    //        _context.Invoices.Remove(invoice);
    //        if(customer.IsSupplier)
    //        {
    //           invoice.Customer.Balance += invoice.Total;
    //        }
    //        else
    //        {
    //           if(invoice.Customer.Balance>0)
    //            {
    //                invoice.Customer.Balance -= invoice.Total;
    //            }
    //            else
    //            {
    //                invoice.Customer.Balance += invoice.Total;
    //            }
    //        }
    //        _context.SaveChanges();
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}
