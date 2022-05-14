using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SortMinElem : BaseInterface
    {
        public double Order(double[] row)
        {
            return row.Min();
        }
    }
}
