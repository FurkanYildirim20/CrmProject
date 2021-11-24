using AuthCrm.Core.BaseEntity;
using AuthCrm.Core.BaseDto;
using AuthCrm.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthCrm.Service
{
    public interface IBaseService<TDto, TEntity,TDal> where TDto : IDto where TEntity :class, IEntity,new() where TDal:IGenericRepository<TEntity>

    {
        Task<List<TDto>> GetItems();
        Task<TDto> Insert(TDto model);
        Task<TDto> Update(TDto model);
        Task Delete(int id);
        Task<TDto> GetById(int id);
    }
}
