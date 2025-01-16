using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CustomerAccountProcess : BaseEntity
    {
        public int CustomerAccountId { get; set; }
        public CustomerAccount CustomerAccount { get; set; }
    }
}
