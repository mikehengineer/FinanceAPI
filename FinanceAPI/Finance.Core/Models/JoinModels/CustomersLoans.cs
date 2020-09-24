using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models.JoinModels
{
    public class CustomersLoans
    {

        public int CustomerId { get; set; }

        public int LoanId { get; set; }

        public Customer Customer { get; set; }

        public Loan Loan { get; set; }

    }
}
