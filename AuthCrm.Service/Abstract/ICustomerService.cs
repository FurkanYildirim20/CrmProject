using AuthCrm.Data.DTOs;
using AuthCrm.Data.Models;
using AuthCrm.DataAccess.Abstruct;
using System.Collections.Generic;

namespace AuthCrm.Service.Abstract
{
    public interface ICustomerService : IBaseService<CustomerDto, Customer, ICustomerDal>
    {
    }
}
