using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AuthCrm.DataAccess.Concrete
{
    public class EfCityDal : GenericRepository<City, AuthDbContext>, ICityDal
    {
        private readonly AuthDbContext _context;
        public EfCityDal(AuthDbContext context) : base(context)
        {
            _context = context;
        }

        public override IQueryable<City> GetQuery()
        {
            return _context.Set<City>().AsQueryable().Include(i => i.Adresses);
        }
        //public CompanyDetailDto GetByCityId(int id)
        //{
        //var result = from ci in _context.Cities
        //             join coci in _context.CompanyCities
        //             on ci.CityId equals coci.CityId
        //             join c in _context.Companies
        //             on coci.CompanyId equals c.CompanyId
        //             where ci.CityId == id
        //             select new CompanyDetailDto
        //             {
        //                 CityId = ci.CityId,
        //                 CompanyName = c.CompanyName,
        //                 CityName = ci.CityName,
        //             };
        //return result.FirstOrDefault();
        //    return null;
        //}
    }
}
