﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QPalindrome
    {
        /* Request: Return if string is a palindrome(same letters forward and backwards)
         * 
         * Example: "racecar" would return TRUE. "cat" would return FALSE. "civic" would return TRUE.
         * 
         * Assume no nulls and no empty strings or single characters.
         */
        public bool PalindromeCheck(string str)
        {
            ////POSSIBLE ANSWER ONE
            //return str == String.Join("", str.Reverse());

            ////POSSIBLE ANSWER TWO
            //var reversed = "";
            //for(int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversed += str[i];
            //}
            //if (str == reversed)
            //{
            //    return true;
            //}
            //return false;

            ////POSSIBLE ANSWER THREE
            //var charArr = str.ToCharArray();
            //var start = 0;
            //var end = charArr.Length - 1;
            //while (start < end)
            //{
            //    if (charArr[start++] != charArr[end--])
            //    {
            //        return false;
            //    }
            //}
            //return true;

            throw new NotImplementedException(); //your code here        
        }
    }
}
