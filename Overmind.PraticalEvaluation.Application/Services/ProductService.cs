using Overmind.PraticalEvaluation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overmind.PraticalEvaluation.Infrastructure.Data.Repositories;

namespace Overmind.PraticalEvaluation.Application.Services
{
    public class ProductService : BaseService<int, Product>, IProductService
    {
        public ProductService(IProductRepository repository): base(repository)
        {

        }
    }
}
