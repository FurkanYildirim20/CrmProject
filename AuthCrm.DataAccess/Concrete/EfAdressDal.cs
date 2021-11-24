using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AuthCrm.DataAccess.Concrete
{
    public class EfAdressDal : GenericRepository<Adress, AuthDbContext>, IAdressDal
    {
        private readonly AuthDbContext _context;
        public EfAdressDal(AuthDbContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<Adress> GetQuery()
        {
            return _context.Set<Adress>().AsQueryable().Include(i => i.City).ThenInclude(i => i.Country);
        }
    }
}
