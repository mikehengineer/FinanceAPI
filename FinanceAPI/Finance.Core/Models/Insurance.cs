using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class Insurance
    {

        public Insurance()
        {
            Customers = new List<CustomersInsurances>();
        }

        public int InsuranceId { get; set; }

        public String InsuranceType { get; set; }

        public int InsuredAmount { get; set; }

        public int InsurancePaymentAmount { get; set; }

        public List<CustomersInsurances> Customers { get; set; }
    }
}
