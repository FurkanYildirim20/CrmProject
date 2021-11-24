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
    public class CompanyManager : BaseService<CompanyDto, Company, ICompanyDal>, ICompanyService
    {
        public CompanyManager(ICompanyDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public List<CompanyDto> CompanyGetAll()
        {
            var data = _repository.GetAll();
            var result= _mapper.Map<List<CompanyDto>>(data);

            return (result);
        }

        public async override Task<List<CompanyDto>> GetItems()
        {
            var data = _repository.GetAll().ToList();

            return await Map(data);
          
        }
        public async override Task<CompanyDto> GetById(int id)
        {
            return (await Map(_repository.GetQuery().Where(i => i.Id == id).ToList())).FirstOrDefault();
        }

        private async Task<List<CompanyDto>> Map(List<Company> data)
        {
            var model = _mapper.Map<List<CompanyDto>>(data);

            model.ForEach(item =>
            {
                var company = data.FirstOrDefault(i => i.Id == item.Id);
                item.Adresses = _mapper.Map<List<AdressDto>>(company.Adresses);
                item.Adresses.ForEach(adress =>
                {
                    adress.City = _mapper.Map<CityDto>(adress.City);
                    adress.Country = _mapper.Map<CountryDto>(adress.Country);
                });
            });
            return model;
        }
    }
}

