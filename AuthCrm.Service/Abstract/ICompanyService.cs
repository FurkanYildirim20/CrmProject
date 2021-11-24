using AuthCrm.Data.Models;
using AuthCrm.Data.DTOs;
using System.Collections.Generic;
using AuthCrm.DataAccess.Abstruct;
using System.Threading.Tasks;

namespace AuthCrm.Service.Abstract
{
    public interface ICompanyService : IBaseService<CompanyDto, Company, ICompanyDal>
    {
        public List<CompanyDto> CompanyGetAll();
    }
}
