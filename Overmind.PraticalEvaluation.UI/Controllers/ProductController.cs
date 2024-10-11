using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Overmind.PraticalEvaluation.Application.Services;
using Overmind.PraticalEvaluation.Domain;

namespace Overmind.PraticalEvaluation.UI.Controllers
{
    public class ProductController : CrudController<int, Product>
    {
        public ProductController(IProductService service) : base(service)
        {
        }
    }
}