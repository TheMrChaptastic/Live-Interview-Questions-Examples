using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QContainsDuplicates
    {
        /* Request: Return if a string has multiples of the same character in it. 
        * 
        * Example: "Hello" would return TRUE because 2 'l'. "Howdy" would return FALSE since no repeats.
        * "Welcome" would return TRUE because 2 'e'.
        * 
        * "Hint: assume all str are lower case.
        * Casing wont matter for this test but could easily be remedied by modifying str casing.
        */
        public bool DuplicatesCheck(string str)
        {
            ////POSSIBLE ANSWER ONE
            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    for (int u = i + 1; u < str.Length; u++)
            //    {
            //        if (str[i] == str[u])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;

            ////POSSIBLE ANSWER TWO
            //var array = str.ToArray();
            //Array.Sort(array);
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if (array[i] == array[i + 1])
            //    {
            //        return true;
            //    }
            //}
            //return false;

            throw new NotImplementedException();
        }
    }
}
