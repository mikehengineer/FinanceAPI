using FinanceAPI.Finance.Core.Models;
using FinanceAPI.Finance.Core.Models.JoinModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Data
{
    public class FinanceAPIDbContext :DbContext
    { 
        public FinanceAPIDbContext(DbContextOptions<FinanceAPIDbContext> options)
            : base(options)
        {

        }

        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<FinanceManager> FinanceManagers { get; set; }

        public DbSet<FinanceOfficer> FinanceOfficers { get; set; }

        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomersBankAccounts>().HasKey(s => new { s.CustomerId, s.BankAccountId });
            modelBuilder.Entity<CustomersCreditCards>().HasKey(s => new { s.CustomerId, s.CreditCardId });
            modelBuilder.Entity<CustomersFinanceOfficers>().HasKey(s => new { s.CustomerId, s.FinanceOfficerId });
            modelBuilder.Entity<CustomersInsurances>().HasKey(s => new { s.CustomerId, s.InsuranceId });
            modelBuilder.Entity<CustomersLoans>().HasKey(s => new { s.CustomerId, s.LoanId });
        }

    }

}
