using AuthCrm.Data.DTOs;
using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AuthCrm.DataAccess.Concrete
{
    public class EfCompanyDal : GenericRepository<Company, AuthDbContext>, ICompanyDal
    {
        private readonly AuthDbContext _context;
        public EfCompanyDal(AuthDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Company> GetAll()
        {
            var result = GetQuery().Include(i => i.Customers.Where(i => i.IsOfficial)).ToList();
            return result;
        }


        //public List<Company> get5()
        //{
        //    var result = GetQuery().Take(5).ToList();
        //    return result;
        //}


        //public List<Company> get5()
        //{
        //pagination
        //    //2 ile 7 arasındakileri listele
        //    var result = GetQuery().Skip(2).Take(5).ToList();
        //    return result;
        //}

        public override IQueryable<Company> GetQuery()
        {
            return _context.Set<Company>().AsQueryable().Include(i => i.Adresses).ThenInclude(i => i.City).ThenInclude(i => i.Country);
        }
    }
}
