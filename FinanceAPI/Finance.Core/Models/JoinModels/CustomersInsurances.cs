using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models.JoinModels
{
    public class CustomersInsurances
    {

        public int CustomerId { get; set; }

        public int InsuranceId { get; set; }

        public Customer Customer { get; set; }

        public Insurance Insurance { get; set; }

    }
}
