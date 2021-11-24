using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AuthCrm.DataAccess.Concrete
{
    public class EfCustomerDal : GenericRepository<Customer, AuthDbContext>, ICustomerDal
    {
        private readonly AuthDbContext _context;
        public EfCustomerDal(AuthDbContext context) : base(context)
        {
            _context = context;
        }

        public override IQueryable<Customer> GetQuery()
        {
            return _context.Set<Customer>().AsQueryable().Include(i => i.Company);
        }
    }
}
