using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Overmind.PraticalEvaluation.Application;
using Overmind.PraticalEvaluation.Application.DI.Configuration;

namespace Overmind.PraticalEvaluation.UI
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            DependencyResolver.SetResolver(new NinjectResolver(new Ioc().Kernel));
        }
    }
}