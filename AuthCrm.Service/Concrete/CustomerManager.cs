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
    public class CustomerManager : BaseService<CustomerDto, Customer, ICustomerDal>, ICustomerService
    {

        public CustomerManager(ICustomerDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async override Task<List<CustomerDto>> GetItems()
        {
            var data = _repository.GetQuery().ToList();
            var model = _mapper.Map<List<CustomerDto>>(data);

            return await Task.FromResult(model);
        }
    }
}