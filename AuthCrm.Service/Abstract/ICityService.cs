using AuthCrm.Data.DTOs;
using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using System.Collections.Generic;

namespace AuthCrm.Service.Abstract
{
    public interface ICityService : IBaseService<CityDto,City,ICityDal>
    {
        //public List<City> GetCities();
        //public List<CompanyDetailDto> GetByCities();
        //public City GetById(int id);
        //public CompanyDetailDto GetByCityId(int id);
        //void Add(City city);
        //void Update(City city);
        //void Delete(City city);
    }
}
