using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class FinanceOfficer
    {

        public FinanceOfficer()
        {
            BankAccounts = new List<BankAccount>();

            CreditCards = new List<CreditCard>();

            Insurances = new List<Insurance>();

            Loans = new List<Loan>();

            Customers = new List<CustomersFinanceOfficers>();
        }


        public int FinanceOfficerId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PhoneNumber { get; set; }

        public String Email { get; set; }

        public List<BankAccount> BankAccounts { get; set; }

        public List<CreditCard> CreditCards { get; set; }

        public List<Insurance> Insurances { get; set; }

        public List<Loan> Loans { get; set; }

        public List<CustomersFinanceOfficers> Customers { get; set; }

        public int FinanceManagerId { get; set; }

    }
}
