using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //The Context uses this interface to call the algorithm defined by Concrete Sorting
    interface ISort
    {
        object RunAlgorithm(object data);
    }
}
