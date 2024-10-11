using Overmind.PraticalEvaluation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.PraticalEvaluation.Infrastructure.Data.Repositories
{
    public interface IBaseRepository<TDataKeyType, TEntity>
        where TEntity : BaseEntity<TDataKeyType>
    {
        Task<TEntity> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> FindById(TDataKeyType id);
        Task<IList<TEntity>> GetAll();
    }

}
