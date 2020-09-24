using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class Loan
    {

        public Loan()
        {
            Customers = new List<CustomersLoans>();
        }

        public int LoanId { get; set; }

        public String LoanType { get; set; }

        public int LoanAmount { get; set; }

        public int LoanBalance { get; set; }

        public int MinimumPayment { get; set; }

        public int AmountDue { get; set; }

        public DateTime DueDate { get; set; }

        public List<CustomersLoans> Customers { get; set; }

    }
}
