using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static JaggedArrayExtension.JaggedArraySort;

namespace JaggedArrayExtension.NUnitTests
{
    public class JaggedArraySortTests
    {
        [TestCase(
            new int[5] {1, 1006, 100, 100, 100},
            new int[3] {2, 1005, 1000},
            new int[3] {3, 1004, 3500},
            new int[3] {4, 1003, 4000},
            new int[3] {5, 1002, 3000},
            new int[3] {6, 1001, 2000},
            ExpectedResult = true)]
        public bool SortTests(params int[][] array)
        {
            bool ans = true;
            array.BubbleSort(new SumAscending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Sum() > array[i + 1].Sum()) ans = false;
            }

            array.BubbleSort(new SumDescending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Sum() < array[i + 1].Sum()) ans = false;
            }

            array.BubbleSort(new MinElementAscending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Min() > array[i + 1].Min()) ans = false;
            }

            array.BubbleSort(new MinElementDescending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Min() < array[i + 1].Min()) ans = false;
            }

            array.BubbleSort(new MaxElementAscending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Max() > array[i + 1].Max()) ans = false;
            }

            array.BubbleSort(new MaxElementDescending());
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Max() < array[i + 1].Max()) ans = false;
            }

            return ans;
        }
    }
}
