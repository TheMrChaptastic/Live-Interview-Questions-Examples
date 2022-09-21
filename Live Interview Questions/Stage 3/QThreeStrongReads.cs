using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    /* Request: You will recieve two arrays of equal length. The first array will be string IDs and the second array will be the 
     * signal strength associated with each read. So ids[0] will be the first scanned id and strength[0] will be that scans strength.
     * A strong read(scan) will be a scan with a strength above 10 (x > 10) Your job is to return the id that is first to have 5 strong reads.
     *
     * Example: If ids = { "a", "b", "c", "a", "a", "b", "c", "a", "b", "c", "b" } and strength = { 12, 9, 16, 11, 7, 12, 10, 9, 12, 11, 15 }
     * Then you would return "b" because its the the first to have 3 strengths over 10.
     */
    public class QThreeStrongReads
    {
        public string FirstToThreeStrongReads(string[] ids, int[] strength)
        {
            ////POSSIBLE ANSWER
            //var dictionary = new Dictionary<string, int>();
            //for(int i = 0; i < ids.Length; i++)
            //{
            //    if (strength[i] > 10)
            //    {
            //        if (dictionary.ContainsKey(ids[i]))
            //        {
            //            dictionary[ids[i]]++;
            //            if (dictionary[ids[i]] == 3)
            //            {
            //                return ids[i];
            //            }
            //        }
            //        else
            //        {
            //            dictionary.Add(ids[i], 1);
            //        }
            //    }
            //}
            //return null;

            throw new NotImplementedException();
        }
    }
}
