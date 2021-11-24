using AuthCrm.Core.BaseEntity;

namespace AuthCrm.Data.Models
{
    public class Adress : BaseEntity
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public string Text { get; set; }
    }
}
