using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QFizzBuzz
    {
        /* Request: Return "Fizz" if the num is divisible by 3.
         * Return "Buzz" if the num is divisible by 5.
         * Return "FizzBuzz" if the num is divisible by 3 and 5.
         * Return the number as a string if it is not divisible by 3 or 5.
         * 
         * Example: 9 would return "Fizz". 10 would return "Buzz".
         * 15 would return "FizzBuzz". 7 would return "7".
         */
        public string FizzBuzz(int num)
        {
            ////POSSIBLE ANSWER ONE (Probably dont do this if they arent fans of ternary readability)
            //return num % 5 == 0 && num % 3 == 0 ? "FizzBuzz" : num % 5 == 0 ? "Buzz" : num % 3 == 0 ? "Fizz" : num.ToString();

            ////POSSIBLE ANSWER TWO
            //var response = "";
            //if (num % 3 == 0)
            //{
            //    response += "Fizz";
            //}
            //if (num % 5 == 0)
            //{
            //    response += "Buzz";
            //}
            //if (response == "")
            //{
            //    response = num.ToString();
            //}
            //return response;

            ////POSSIBLE ANSWER THREE
            //StringBuilder response = new StringBuilder("");
            //if (num % 3 == 0)
            //{
            //    response.Append("Fizz");
            //}
            //if (num % 5 == 0)
            //{
            //    response.Append("Buzz");
            //}
            //if (response.ToString() == "")
            //{
            //    return num.ToString();
            //}
            //return response.ToString();

            throw new NotImplementedException();
        }
    }
}
