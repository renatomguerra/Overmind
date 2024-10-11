using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overmind.PraticalEvaluation.Domain;
using Overmind.PraticalEvaluation.Infrastructure.Data.Repositories;

namespace Overmind.PraticalEvaluation.Application.Services
{
    public class BaseService<TDataKeyType, TEntity> : IBaseService<TDataKeyType, TEntity>
          where TEntity : BaseEntity<TDataKeyType>

    {
        private IBaseRepository<TDataKeyType, TEntity> _repository = null;

        public BaseService(IBaseRepository<TDataKeyType, TEntity> repository) 
        {
            _repository = repository;
        }

        public Task<TEntity> Add(TEntity entity)
        {
            return _repository.Add(entity);
        }

        public Task Delete(TEntity entity)
        {
            return _repository.Delete(entity);
        }

        public Task<TEntity> FindById(TDataKeyType id)
        {
            return _repository.FindById(id);
        }

        public Task<IList<TEntity>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
    }
}
