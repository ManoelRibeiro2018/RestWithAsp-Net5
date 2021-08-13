using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Specification.Interface
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T Entity);
    }
}
