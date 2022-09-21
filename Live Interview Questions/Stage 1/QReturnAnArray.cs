using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QReturnAnArray
    {
        // RETURN AN EMPTY ARRAY OF STRINGS
        public string[] ReturnEmptyStringArray()
        {
            ////ANSWER ONE
            //var list = new List<string>();
            //return list.ToArray();

            ////ANSWER TWO
            //var array = new string[0];
            //return array;

            ////ANSWER THREE
            //return new string[0];

            throw new NotImplementedException();
        }

        // RETURN AN EMPTY ARRAY OF INTEGERS 
        public int[] ReturnEmptyIntArray()
        {
            ////ANSWER ONE
            //var list = new List<int>();
            //return list.ToArray();

            ////ANSWER TWO
            //var array = new int[0];
            //return array;

            ////ANSWER THREE
            //return new int[0];

            throw new NotImplementedException();
        }

        // RETURN AN ARRAY OF INTEGERS FROM 1 TO N
        // Example: n = 1 would return int[] { 1 }.
        // n = 3 would return int[] { 1, 2, 3 }.
        public int[] ReturnIntArrayFrom1ToN(int n)
        {
            ////ANSWER ONE
            //var list = new List<int>();
            //for(int i = 1; i <= n; i++)
            //{
            //    list.Add(i);
            //}
            //return list.ToArray();

            ////ANSWER TWO
            //var array = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    array[i] = i + 1;
            //}
            //return array;

            throw new NotImplementedException();
        }
    }
}
