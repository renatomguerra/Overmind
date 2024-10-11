using Ninject;
using Overmind.PraticalEvaluation.Application.DI.Modules;
using System;

namespace Overmind.PraticalEvaluation.Application.DI.Configuration
{
    public class Ioc: IDisposable
    {
        private IKernel _kernel;
        public Ioc() 
        {
            _kernel = new StandardKernel(new RepositoryModules(), new ServiceModules());
        }
        public IKernel Kernel
        {
            get 
            {   
                return _kernel; 
            }
        }
        public void Dispose()
        {
            if (_kernel != null)
            {
                _kernel.Dispose();
            }
        }
    }
}
