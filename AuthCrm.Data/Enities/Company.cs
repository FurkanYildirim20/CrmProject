using AuthCrm.Core.BaseEntity;
using System.Collections.Generic;

namespace AuthCrm.Data.Models
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }

        public List<Adress> Adresses { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
