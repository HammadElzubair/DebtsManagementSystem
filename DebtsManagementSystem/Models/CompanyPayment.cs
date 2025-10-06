using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Models
{
    public  class CompanyPayment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionNumber { get; set; } = ""; // رقم العملية البنكية (فريد)
        public DateTime Date { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}
