using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtension
{
    public class MaxElementDescending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            JaggedArraySort.CheckNullArgument(lhs, rhs);
            return lhs.Max() < rhs.Max() ? 1 : -1;
        }
    }
}
