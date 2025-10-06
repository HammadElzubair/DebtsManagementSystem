using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public decimal Balance { get; set; } // موجب = مدين / سالب = دائن
        public string Status
        {
            get
            {
                if (Balance > 0) return "مدين";
                if (Balance < 0) return "دائن";
                return "مسدد بالكامل";
            }
        }
        public bool IsSupplier { get; set; }
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();


    }
}
