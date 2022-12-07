using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QReverseAString
    {
        /* Request: Return the string reversed.
         * 
         * Example: "cat" would return "tac" || "dog" would return "god"
         * "Hello World!" would return "!dlroW olleH"
         * null will return "" (empty string)
         */
        public string ReverseString(string str)
        {
            ////ANSWER ONE
            //if (str == null)
            //{
            //    return "";
            //}
            //return String.Join("", str.Reverse());

            ////ANSWER TWO
            //if (str == null)
            //{
            //    return "";
            //}
            //var reversed = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversed += str[i];
            //}
            //return reversed;

            ////ANSWER THREE
            //if (str == null)
            //{
            //    return "";
            //}
            //var reversed = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    reversed = str[i] + reversed; 
            //}
            //return reversed;

            ////ANSWER FOUR
            //var charArr = str?.ToCharArray();
            //var start = 0;
            //var end = charArr?.Length - 1 ?? 0;
            //while (start < end)
            //{
            //    var temp = charArr[start];
            //    charArr[start++] = charArr[end];
            //    charArr[end--] = temp;
            //}
            //return charArr != null ? string.Join("", charArr) : "";

            ////ANSWER FIVE
            //StringBuilder result = new StringBuilder("");
            //if (str == null)
            //{
            //    return result.ToString();
            //}
            //for(int i = str.Length - 1; i >= 0; i--)
            //{
            //    result.Append(str[i]);
            //}
            //return result.ToString();

            throw new NotImplementedException();
        }
    }
}
