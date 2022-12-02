using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QSumOfTwoIndexesToTarget
    {
        /* Request: Return two lowest indexes thats values add up to the target number.
         * 
         * Example: The array(arr) [ 1, 3, 5 ] and the target 8 will return new int[] { 1, 2 } 
         * because the index 1 => (3) and index 2 => (5) sums are equal to the target number 8.
         * BE CAREFUL OF SORTING SINCE THE ANSWER IS BASED ON ORIGINAL INDEXES
         * 
         * Assume no nulls and each test has a valid answer associated with it.
         */
        public int[] SumOfTwoIndexesEqualTarget(int[] arr, int target)
        {
            ////POSSIBLE ANSWER
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int u = i + 1; u < arr.Length; u++)
            //    {
            //        if (arr[i] + arr[u] == target)
            //        {
            //            return new int[] { i, u };
            //        }
            //    }
            //}
            //return new int[0];

            ////POSSIBLE ANSWER
            //var dic = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    var rem = target - arr[i];
            //    if (dic.ContainsKey(rem))
            //    {
            //        return new int[2] { dic[rem], i }; 
            //    }
            //    if (!dic.ContainsKey(arr[i]))
            //    {
            //        dic.Add(arr[i], i);
            //    }
            //}
            //return new int[0];

            throw new NotImplementedException();
        }
    }
}
