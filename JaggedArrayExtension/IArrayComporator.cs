using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtension
{
    public interface IArrayComporator
    {
        /// <summary>
        /// Method to compare 2 int arrays
        /// </summary>
        /// <param name="lhs">first array</param>
        /// <param name="rhs">second array</param>
        /// <returns>1 if swap is needed, -1 else</returns>
        int Compare(int[] lhs, int[] rhs);
    }
}
