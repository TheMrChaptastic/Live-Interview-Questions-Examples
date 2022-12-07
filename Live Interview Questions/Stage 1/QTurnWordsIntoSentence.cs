using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QTurnWordsIntoSentence
    {
        /* Request: Return a string with each string in arr put together as a sentence. Single spaces between each word.
         * 
         * Example: { "Hello", "World!" } will return "Hello World!". 
         * { "Now", "this", "is", "podracing!" } will return "Now this is podracing!"
         * null will return "" (empty string)
         */
        public string WordsIntoSentence(string[] arr)
        {

            ////EXAMPLE ONE
            //if (arr == null)
            //{
            //    return "";
            //}
            //var sentence = "";
            //for (int i = 0; i < arr.length; i++)
            //{
            //    sentence += arr[i] + " ";
            //}
            //return sentence.trim();

            ////EXAMPLE TWO
            //if (arr == null)
            //{
            //    return "";
            //}
            //return String.Join(' ', arr);

            ////EXAMPLE THREE
            //if (arr == null)
            //{
            //    return String.Empty;
            //}
            //StringBuilder sentence = new StringBuilder(arr[0]);
            //for(int i = 1; i < arr.Length; i++)
            //{
            //    sentence.Append(" " + arr[i]);
            //}
            //return sentence.ToString();

            throw new NotImplementedException();
        }
    }
}
