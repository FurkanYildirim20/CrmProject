using AuthCrm.Core.BaseDto;
using AuthCrm.Data.Models;
using System.Collections.Generic;

namespace AuthCrm.Data.DTOs
{
    public class CompanyDto : BaseDto
    {
        public string Name { get; set; }

        public List<AdressDto> Adresses { get; set; }
        public List<CustomerDto> Customers { get; set; }
        public List<CountryDto> Countries { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}
