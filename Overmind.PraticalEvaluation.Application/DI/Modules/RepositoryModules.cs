using Ninject.Modules;
using Overmind.PraticalEvaluation.Infrastructure.Data.Repositories;

namespace Overmind.PraticalEvaluation.Application.DI.Modules
{
    public class RepositoryModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}
