using AuthCrm.Core.BaseDto;
using System.Collections.Generic;

namespace AuthCrm.Data.DTOs
{
    public class AdressDto : BaseDto
    {
        public string Text { get; set; }

        public CityDto City { get; set; }

        public CountryDto Country{ get; set; }
    }
}
