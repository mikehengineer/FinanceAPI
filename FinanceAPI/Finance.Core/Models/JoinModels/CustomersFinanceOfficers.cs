using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models.JoinModels
{
    public class CustomersFinanceOfficers
    {

        public int CustomerId { get; set; }

        public int FinanceOfficerId { get; set; }

        public Customer Customer { get; set; }

        public FinanceOfficer FinanceOfficer { get; set; }

    }
}
