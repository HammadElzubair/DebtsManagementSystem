using DebtsManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtsManagementSystem.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CompanyPayment> CompanyPayments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//DESKTOP-933ON0K\SQLEXPRESS//DESKTOP-9MRI1K0\SQLEXPRESS
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9MRI1K0\SQLEXPRESS;Database=CustomerDebtDB;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Payment>()
                .HasIndex(p => p.TransactionNumber).IsUnique();
               
            modelBuilder.Entity<CompanyPayment>()
                .HasIndex(p => p.TransactionNumber).IsUnique();
               
        }
    }
}
