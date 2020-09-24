using FinanceAPI.Finance.Core.Models.JoinModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class CreditCard
    {

        public CreditCard()
        {
            Customers = new List<CustomersCreditCards>();
        }

        public int CreditCardId { get; set; }

        public String CreditCardCompany { get; set; }

        public int CreditCardInterestRate { get; set; }

        public int CreditLimit { get; set; }

        public DateTime CreditCardExpiration { get; set; }

        public int CurrentBalance { get; set; }

        public int MinimumPayment { get; set; }

        public int AmountDue { get; set; }

        public DateTime DueDate { get; set; }

        public List<CustomersCreditCards> Customers { get; set; }

    }
}
