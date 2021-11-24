using AuthCrm.Data.Models;
using AuthCrm.Data.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace AuthCrm.DataAccess.Abstruct
{
    public interface ICompanyDal : IGenericRepository<Company>
    {
        public List<Company> GetAll();
    }
}
