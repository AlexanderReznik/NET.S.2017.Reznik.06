using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtension
{
    class InterfaceImplementationFromDelegat : IComparer<int[]>
    {
        private readonly Comparison<int[]> _comparison;

        public InterfaceImplementationFromDelegat(Comparison<int[]> comp)
        {
            _comparison = comp;
        }

        public int Compare(int[] x, int[] y)
        {
            return _comparison(x, y);
        }
    }
}
