using AuthCrm.Core.BaseEntity;

namespace AuthCrm.Data.Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsOfficial { get; set; }
    }
}