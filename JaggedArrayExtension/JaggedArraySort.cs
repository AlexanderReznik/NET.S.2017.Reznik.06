using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtension
{
    public static class JaggedArraySort
    {
        /// <summary>
        /// Method for sorting a jagged array using bubble sort algorithm
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="comp">Comporator</param>

        #region first version
        public static void BubbleSort(this int[][] array, IComparer<int[]> comp)
        {
            for(int i = 0; i < array.Length; i++)
                for(int j = 0; j < array.Length - 1; j++)
                    if (comp.Compare(array[j], array[j + 1]) == 1)
                        Swap(ref array[j], ref array[j + 1]);
        }

        public static void BubbleSort(this int[][] array, Comparison<int[]> comp)
        {
            BubbleSort(array, new InterfaceImplementationFromDelegat(comp));
        }
        #endregion
    
        #region second version
        /*public static void BubbleSort(this int[][] array, IComparer<int[]> comp)
        {
            BubbleSort(array, comp.Compare);
        }

        public static void BubbleSort(this int[][] array, Comparison<int[]> comp)
        {
            for (int i = 0; i < array.Length; i++)
            for (int j = 0; j < array.Length - 1; j++)
                if (comp(array[j], array[j + 1]) == 1)
                    Swap(ref array[j], ref array[j + 1]);
        }*/
        #endregion
    
        private static void Swap(ref int[] lhs, ref int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static void CheckNullArgument(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) throw new ArgumentNullException();
        }
    }
}
