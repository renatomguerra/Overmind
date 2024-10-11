using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.PraticalEvaluation.Domain
{
    public abstract class BaseEntity<TDataKeyType>
    {
        public TDataKeyType Id { get; set; }
    }
}
