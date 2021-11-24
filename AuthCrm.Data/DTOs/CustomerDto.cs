using AuthCrm.Core.BaseDto;
using AuthCrm.Data.Models;

namespace AuthCrm.Data.DTOs
{
    public class CustomerDto : BaseDto
    {
        public string Name { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsOfficial { get; set; }
    }
}
