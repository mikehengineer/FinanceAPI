using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models.JoinModels
{
    public class CustomersBankAccounts
    {

        public int CustomerId { get; set; }

        public int BankAccountId { get; set; }

        public Customer Customer { get; set; }

        public BankAccount BankAccount { get; set; }

    }
}
