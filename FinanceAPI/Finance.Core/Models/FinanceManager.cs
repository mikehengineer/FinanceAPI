using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceAPI.Finance.Core.Models
{
    public class FinanceManager
    {

        public FinanceManager()
        {
            FinanceOfficers = new List<FinanceOfficer>();
        }


        public int FinanceManagerId { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String PhoneNumber { get; set; }

        public String Email { get; set; }

        public List<FinanceOfficer> FinanceOfficers { get; set; }

    }
}
