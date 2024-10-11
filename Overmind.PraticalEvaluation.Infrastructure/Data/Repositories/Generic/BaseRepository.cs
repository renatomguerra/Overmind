using Overmind.PraticalEvaluation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overmind.PraticalEvaluation.Infrastructure.Net.Http;

namespace Overmind.PraticalEvaluation.Infrastructure.Data.Repositories
{
    public class BaseRepository<TDataKeyType, TEntity> : IBaseRepository<TDataKeyType, TEntity>
      where TEntity : BaseEntity<TDataKeyType>

    {
        private RestApiRequest<TDataKeyType, TEntity> _restApiRequest = null;
        public BaseRepository()            
        {
            _restApiRequest = new RestApiRequest<TDataKeyType, TEntity>("https://restful-api.dev/");
        }

        public Task<TEntity> Add(TEntity entity)
        {
            var result = _restApiRequest.Post(entity);
            return result;
        }

        public Task Delete(TEntity entity)
        {
            return _restApiRequest.Delete(entity.Id);
        }

        public Task<TEntity> FindById(TDataKeyType id)
        {
            return _restApiRequest.Get(id); 
        }

        public Task<IList<TEntity>> GetAll()
        {
            return _restApiRequest.Get();
        }

        public Task Update(TEntity entity)
        {
            return _restApiRequest.Put(entity.Id, entity);
        }

    }

}
