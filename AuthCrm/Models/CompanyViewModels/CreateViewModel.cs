using AuthCrm.Data.DTOs;
using System.Collections.Generic;

namespace AuthCrm.Models.CompanyViewModels
{
    public class CreateViewModel
    {
        public CompanyDto Company { get; set; }

        public List<CityDto> Cities { get; set; }

        public List<AdressDto> Adresses { get; set; }
    }
}
