using DebtsManagementSystem.Data;
using DebtsManagementSystem.Models;
using DebtsManagementSystem.Services;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

public class PaymentService
{
    //private readonly AppDbContext _context;
    //public PaymentService(AppDbContext context) => _context = context;

    //public bool AddCustomerPayment(int customerId, string transactionNumber, decimal amount, DateTime date, string note)
    //{
    //    if (_context.Payments.Any(p => p.TransactionNumber == transactionNumber))
    //        return false;

    //    var customer = _context.Customers.Find(customerId);
    //    if (customer == null) throw new Exception("العميل غير موجود");

    //    var payment = new Payment
    //    {
    //        CustomerId = customerId,
    //        TransactionNumber = transactionNumber,
    //        Amount = amount,
    //        Date = date,
    //        Note = note
    //    };

    //        customer.Balance -= amount; // خصم المبلغ   

    //    _context.Payments.Add(payment);
    //    _context.SaveChanges();
    //    return true;
    //}

    //public bool AddCompanyPayment(int supplierId, string transactionNumber, decimal amount, DateTime date, string note)
    //{
    //    if (_context.CompanyPayments.Any(p => p.TransactionNumber == transactionNumber))
    //        return false;

    //    var company = _context.Customers.Find(supplierId);
    //    if (company == null) throw new Exception("الشركة غير موجودة");

    //    var payment = new CompanyPayment
    //    {
    //        TransactionNumber = transactionNumber,
    //        Amount = amount,
    //        Date = date,
    //        Note = note

    //    };

    //    company.Balance += amount;

    //    _context.CompanyPayments.Add(payment);
    //    _context.SaveChanges();
    //    return true;
    //}
    //public CompanyPayment GetCompanyPaymentById(int id)
    //{
    //    return _context.CompanyPayments.Find(id);
    //}
    //public Payment GetCustomerPaymentById(int id)
    //{
    //    return _context.Payments.Find(id);
    //}
    //public  bool DeletePyment(int customerId, int paymentId)
    //{
    //    decimal balance = 0;
    //    bool flag = false;
    //    var customer = _context.Customers.Find(customerId);

    //    if (customer != null)
    //    {
    //        if (customer.IsSupplier)
    //        {
    //            var payment = _context.CompanyPayments.Find(paymentId);
    //            if (payment != null)
    //            {
    //                balance = payment.Amount;
    //                _context.CompanyPayments.Remove(payment);
    //                _context.SaveChanges();
    //                customer.Balance -= balance;
    //                flag = true;

    //            }
    //            else return false;
    //        }
    //        else
    //        {
    //            var payment = _context.Payments.Find(paymentId);
    //            if (payment != null)
    //            {
    //                balance = payment.Amount;
    //                _context.Payments.Remove(payment);
    //                customer.Balance += balance;
    //                _context.SaveChanges();
    //                flag = true;
    //            }
    //        }

    //    }
    //    return flag;
    //}
    //public bool BankNoCheeking(string bankNo)
    //{
    //    if (_context.Payments.Any(p => p.TransactionNumber == bankNo))
    //        return false;
    //    else
    //        return true;
    //}
    //public List<Payment> GetCustomerPayment(int id)
    //{
    //    var payment = _context.Payments.Where(p => p.CustomerId == id).ToList();
    //    return payment;
    //}
    //public List<CompanyPayment> GetCompanyPayment()
    //{
    //    return _context.CompanyPayments.ToList();
    //}
    //public bool UpdatePayment(int id, int customerId, decimal amount, string note, DateTime date)
    //{
    //    bool flag = false;
    //    var customer = _context.Customers.Find(customerId);

    //    if (customer != null)
    //    {
    //        if (customer.IsSupplier)
    //        {
    //            var payment = _context.CompanyPayments.FirstOrDefault(p => p.Id == id);
    //            if (payment != null)
    //            {
    //                //Decrise Customer Balance 
    //                customer.Balance -= payment.Amount;
    //                payment.Amount = amount;
    //                payment.Note = note;
    //                payment.Date = date;
    //                //
    //                customer.Balance += amount;
    //                _context.CompanyPayments.Update(payment);
    //                _context.SaveChanges();
    //                flag = true;
    //            }

    //        }
    //        else
    //        {
    //            var payment = _context.Payments.FirstOrDefault(p=>p.Id==id);
    //            if (payment != null)
    //            {
    //                //نقص رصيد العميل من المبلغ القديم 
    //                if (customer.Balance>0)
    //                {
    //                    customer.Balance -= payment.Amount;
    //                }
    //                else
    //                {
    //                    customer.Balance += payment.Amount;
    //                }

    //                payment.Amount = amount;
    //                payment.Note = note;
    //                payment.Date = date;
    //                //تعديل رصيد العميل بعؤ تعديل عمليه الدفع
    //                customer.Balance -= amount;
    //                _context.Payments.Update(payment);
    //                _context.SaveChanges();
    //                flag = true;
    //            }
    //        }

    //    }

    //    return flag;
    //}
    AppDbContext _context = DbContextFactory.context;
    private readonly BalanceHelper _balanceHelper;

    public PaymentService()
    {
      
        _balanceHelper = new BalanceHelper(_context);
    }

    public bool AddCustomerPayment(int customerId, string transactionNumber, decimal amount, DateTime date, string note)
    {
        // تحقق من تكرار رقم العملية
        if (_context.Payments.Any(p => p.TransactionNumber == transactionNumber))
            return false;

        using var tx = _context.Database.BeginTransaction();
        try
        {
            var payment = new Payment
            {
                CustomerId = customerId,
                TransactionNumber = transactionNumber,
                Amount = amount,
                Date = date,
                Note = note
            };

            _context.Payments.Add(payment);
            _context.SaveChanges();

            // أعِد حساب الرصيد بدقة
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
    public bool AddCompanyPayment(int customerId, string transactionNumber, decimal amount, DateTime date, string note)
    {
        // تحقق من تكرار رقم العملية
        if (_context.CompanyPayments.Any(p => p.TransactionNumber == transactionNumber))
            return false;

        using var tx = _context.Database.BeginTransaction();
        try
        {
            var payment = new CompanyPayment
            {
                CustomerId = customerId,
                TransactionNumber = transactionNumber,
                Amount = amount,
                Date = date,
                Note = note
            };

            _context.CompanyPayments.Add(payment);
            _context.SaveChanges();

            // أعِد حساب الرصيد بدقة
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

    public bool EditCustomerPayment(int paymentId, decimal newAmount, DateTime newDate, string newNote)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var payment = _context.Payments.Include(p => p.Customer).FirstOrDefault(p => p.Id == paymentId);
            if (payment == null) return false;

            payment.Amount = newAmount;
            payment.Date = newDate;
            payment.Note = newNote;

            _context.Payments.Update(payment);
            _context.SaveChanges();

            // إعادة حساب موثوق للرصيد
            _balanceHelper.RecalculateAndSetBalance(payment.CustomerId);

            tx.Commit();
            return true;
        }
        catch
        {
            tx.Rollback();
            throw;
        }
    }

    public bool DeleteCustomerPayment(int paymentId)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var payment = _context.Payments.FirstOrDefault(p => p.Id == paymentId);
            if (payment == null) return false;

            var customerId = payment.CustomerId;
            _context.Payments.Remove(payment);
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
    public bool DeleteCompanyPayment(int paymentId)
    {
        using var tx = _context.Database.BeginTransaction();
        try
        {
            var payment = _context.CompanyPayments.FirstOrDefault(p => p.Id == paymentId);
            if (payment == null) return false;

            var customerId = payment.CustomerId;
            _context.CompanyPayments.Remove(payment);
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
    public CompanyPayment GetCompanyPaymentById(int id)
    {
        return _context.CompanyPayments.Find(id);
    }
    public Payment GetCustomerPaymentById(int id)
    {
        return _context.Payments.Find(id);
    }
    public List<CompanyPayment> GetCompanyPayment()
    {
        return _context.CompanyPayments.ToList();
    }
    public List<Payment> GetCustomerPayment(int id)
    {
        var payment = _context.Payments.Where(p=>p.CustomerId==id).ToList();
        return payment;
    }
    public List<Payment> GetAllCustomerPayment()
    {
        var payment = _context.Payments.ToList();
        return payment;
    }
}

