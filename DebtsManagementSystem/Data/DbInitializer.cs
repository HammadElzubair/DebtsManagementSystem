using DebtsManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.Migrate();
            if(!context.Customers.Any())
            {
                context.Customers.Add(new Customer { Name = "الشركه", IsSupplier = true , Balance = 0 });
            }
            context.SaveChanges();
        }
    } 
}
