using AuthCrm.Core.BaseEntity;
using System.Collections.Generic;

namespace AuthCrm.Data.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public List<City> Cities { get; set; }
        public List<Adress> Adresses { get; set; }
    }
}
