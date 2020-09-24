using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class BankAccount
    {

        public BankAccount()
        {
            Customers = new List<CustomersBankAccounts>();
        }

        public int BankAccountId { get; set; }

        public String BankAccountType { get; set; }

        public int BankAccountBalance { get; set; }

        public List<CustomersBankAccounts> Customers { get; set; }

    }
}
