// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSLibrary
{
    public class Sorting
    {
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public Sorting() { }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// O(n) used for smaller data sets.
        /// The Insert sort was not used as it is better practice to use .sort() as
        /// visual studio will see which algorithm is best suited to sort the data.
        ///https://www.csharpstar.com/csharp-program-to-perform-insertion-sort/
        /// </summary>
        /// <param name="data"></param>
        /// <param name="n"></param>
        public void InsertSort(int[] data, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}
//===============================================================================================//
///References
///https://www.csharpstar.com/csharp-program-to-perform-insertion-sort/
///The following was used to acomplish the insertion sort.