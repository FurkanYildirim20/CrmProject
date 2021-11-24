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
    public class CityManager : BaseService<CityDto, City, ICityDal>, ICityService
    {
        public CityManager(ICityDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async override Task<List<CityDto>> GetItems()
        {
            var data = _repository.GetQuery().ToList();
            var model = _mapper.Map<List<CityDto>>(data);

            return await Task.FromResult(model);
        }
    }
}