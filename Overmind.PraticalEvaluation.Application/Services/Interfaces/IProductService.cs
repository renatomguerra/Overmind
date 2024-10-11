using Overmind.PraticalEvaluation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.PraticalEvaluation.Application.Services
{
    public interface IProductService: IBaseService<int, Product>
    {
    }
}
