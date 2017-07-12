using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtension
{
    public class SumAscending : IArrayComporator
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            JaggedArraySort.CheckNullArgument(lhs, rhs);
            return lhs.Sum() > rhs.Sum() ? 1 : -1;
        }
    }
}
