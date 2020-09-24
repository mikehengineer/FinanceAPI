using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class Customer
    {

        public Customer()
        {
            FinanceOfficers = new List<CustomersFinanceOfficers>();

            BankAccounts = new List<CustomersBankAccounts>();

            CreditCards = new List<CustomersCreditCards>();

            Insurances = new List<CustomersInsurances>();

            Loans = new List<CustomersLoans>();
        }

        public int CustomerId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PhoneNumber { get; set; }

        public String Email { get; set; }

        public List<CustomersFinanceOfficers> FinanceOfficers { get; set; }

        public List<CustomersBankAccounts> BankAccounts { get; set; }

        public List<CustomersCreditCards> CreditCards { get; set; }

        public List<CustomersInsurances> Insurances { get; set; }

        public List<CustomersLoans> Loans { get; set; }

    }
}
