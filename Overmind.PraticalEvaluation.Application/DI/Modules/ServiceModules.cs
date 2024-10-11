using Ninject.Modules;
using Overmind.PraticalEvaluation.Application.Services;

namespace Overmind.PraticalEvaluation.Application.DI.Modules
{
    public class ServiceModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
        }
    }
}
