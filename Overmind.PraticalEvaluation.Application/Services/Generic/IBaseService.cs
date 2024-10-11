using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overmind.PraticalEvaluation.Domain;

namespace Overmind.PraticalEvaluation.Application.Services
{
    public interface IBaseService<TDataKeyType, TEntity> 
        where TEntity: BaseEntity<TDataKeyType>
    {
        Task<TEntity> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> FindById(TDataKeyType id);
        Task<IList<TEntity>> GetAll();
    }
}
