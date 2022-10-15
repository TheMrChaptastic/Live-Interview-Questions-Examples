using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Live_Interview_Questions
{
    public class QMaximumProfits
    {
        //    Request: We need to find out the maximum difference(which will be the maximum profit) between two numbers in the given array.
        //    Also, the second number(selling price) must be larger than the first one(buying price).
        //    We need to find max(prices[j] - prices[i]) for every i and j such that j > i.
        //    
        //    Example:
        //    { 19, 3, 4, 6, 1 } would result in a return value of 3 because the greatest gain would be between 3 -> 6 for a gain of 3. { 19, ((3, 4, 6,)) 1 }
        //    { 7, 1, 5, 3, 6, 4 } would return 5. { 7, ((1, 5, 3, 6,)) 4 } +5 gain
        //    { 1, 3, 2, 7, 3 } would return 6. { ((1, 3, 2, 7,)) 3 } +6 gain

        public int MaxProfit(int[] prices)
        {
            throw new NotImplementedException();
        }
    }
}
