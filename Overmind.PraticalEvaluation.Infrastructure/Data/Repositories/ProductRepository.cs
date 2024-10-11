using Overmind.PraticalEvaluation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.PraticalEvaluation.Infrastructure.Data.Repositories
{
    public class ProductRepository: BaseRepository<int, Product>, IProductRepository
    {
    }
}
