using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AuthCrm.DataAccess.Concrete
{
    public class EfCountryDal : GenericRepository<Country, AuthDbContext>, ICountryDal
    {
        private readonly AuthDbContext _context;
        public EfCountryDal(AuthDbContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<Country> GetQuery()
        {
            return _context.Set<Country>().AsQueryable().Include(i=>i.Adresses);
        }
    }
}
