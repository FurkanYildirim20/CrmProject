using AuthCrm.Core.BaseDto;
using System.Collections.Generic;

namespace AuthCrm.Data.DTOs
{
    public class CityDto : BaseDto
    {
        public string Name { get; set; }
        public List<CountryDto> Countries { get; set; }

    }
}
