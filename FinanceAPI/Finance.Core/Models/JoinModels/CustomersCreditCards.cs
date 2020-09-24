using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models.JoinModels
{
    public class CustomersCreditCards
    {

        public int CustomerId { get; set; }

        public int CreditCardId { get; set; }

        public Customer Customer { get; set; }

        public CreditCard CreditCard { get; set; }

    }
}
