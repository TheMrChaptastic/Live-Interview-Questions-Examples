using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QSumTwoToTargetNumber
    {
        /* Request: Return if two different elements in arr can add together to equal the target number.
         * 
         * Example: arr = { 1, 3, 5 } and target = 6 would return TRUE since 1 + 5 = 6.
         * arr = { 1, 3, 5 } and target = 4 would return TRUE since 1 + 3 = 4.
         * arr = { 1, 3, 5 } and target = 3 would return FALSE since none of the numbers add up to equal 3.
         */
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] arr, int target)
        {
            ////POSSIBLE ANSWER ONE
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int u = i + 1; u < arr.Length; u++)
            //    {
            //        if (target == arr[i] + arr[u])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;

            ////POSSIBLE ANSWER TWO
            //var start = 0;
            //var end = arr.Length - 1;
            //Array.Sort(arr);
            //while (start < end)
            //{
            //    if (arr[start] + arr[end] == target)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        if (arr[start] + arr[end] > target)
            //        {
            //            end--;
            //        }
            //        else
            //        {
            //            start++;
            //        }
            //    }
            //}
            //return false;

            ////POSSIBLE ANSWER THREE
            //var list = new List<int>();
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (list.Contains(target - arr[i]))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        list.Add(arr[i]);
            //    }
            //}
            //return false;

            throw new NotImplementedException();
        }
    }
}
