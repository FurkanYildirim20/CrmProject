using AuthCrm.Core.BaseDto;
using AuthCrm.Core.BaseEntity;
using AuthCrm.DataAccess;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthCrm.Service
{
    public class BaseService<TDto, TEntity, TDal> : IBaseService<TDto, TEntity, TDal> where TDto : IDto where TEntity : class, IEntity, new() where TDal : IGenericRepository<TEntity>

    {
        protected readonly TDal _repository;
        protected readonly IMapper _mapper;

        public BaseService (TDal repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task Delete(int id)
        {
            await Task.Run(() => { _repository.Delete(id); });
        }

        public virtual async Task<TDto> GetById(int id)
        {
            return await Task.FromResult(_mapper.Map<TDto>(_repository.GetById(id)));
        }

        public virtual async Task<List<TDto>> GetItems()
        {
            return _mapper.Map<List<TDto>>(_repository.GetList());
        }

        public virtual async Task<TDto> Insert(TDto model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Add(entity);
            return  await Task.FromResult(model);
        }

        public virtual async Task<TDto> Update(TDto model)
        {
            var entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
            return await Task.FromResult(model);
        }
    }
}
