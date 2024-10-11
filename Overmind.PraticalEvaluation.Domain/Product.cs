using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.PraticalEvaluation.Domain
{
    public  class Product: BaseEntity<int>
    {        
        public string Name { get; }
        public ProductDetail Data { get; set; }
    }
}
