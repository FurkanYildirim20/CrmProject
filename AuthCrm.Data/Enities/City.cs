using AuthCrm.Core.BaseEntity;
using System.Collections.Generic;

namespace AuthCrm.Data.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Adress> Adresses { get; set; }
    }
}
