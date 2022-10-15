using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QMergeSortTwoLists
    {
        /* Request: Return the a list that contains the sorted elements of both lists coming from the method parameters.
        * 
        * Example: { 1, 3, 2 } and { 5, 2 } would return { 1, 2, 2, 3, 5 }.
        * { 5, 3, 2 } and { } would return { 2, 3, 5 }.
        *
        * Hint: Lists recieved could be empty but you still need to return a List of type int. Do not return null.
        */
        public List<int> MergeSortTwoLists(List<int> list1, List<int> list2)
        {
            ////POSSIBLE ANSWER 1
            //var list = new List<int>();
            //foreach(var item in list1)
            //{
            //    list.Add(item);
            //}
            //foreach(var item in list2)
            //{
            //    list.Add(item);
            //}

            //var temp = 0;

            //for(int i = 0; i < list.Count - 1; i++)
            //{
            //    if (list[i] > list[i + 1])
            //    {
            //        temp = list[i];
            //        list[i] = list[i + 1];
            //        list[i + 1] = temp;
            //        i = -1;
            //    }
            //}

            //return list;

            ////POSSIBLE ANSWER 2
            //var list = new List<int>();
            //list1.ForEach(x => list.Add(x));
            //list2.ForEach(x => list.Add(x));
            //list.Sort();
            //return list;

            throw new NotImplementedException();
        }
    }
}
