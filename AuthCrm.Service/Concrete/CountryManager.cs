using AuthCrm.Data.DTOs;
using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.Service.Abstract;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthCrm.Service.Concrete
{
    public class CountryManager : BaseService<CountryDto, Country, ICountryDal>, ICountryService
    {
        public CountryManager(ICountryDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async override Task<List<CountryDto>> GetItems()
        {
            var data = _repository.GetQuery().ToList();
            var model = _mapper.Map<List<CountryDto>>(data);

            return await Task.FromResult(model);
        }

    }
}
