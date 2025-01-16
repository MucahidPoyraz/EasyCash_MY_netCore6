using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Currency : BaseEntity
    {
        public string CurrencyType { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
