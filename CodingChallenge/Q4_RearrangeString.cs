/*
You are given a string. Rearrange characters of this string in non-ascending order and output the resulting string.

The input data consists of a single string. The length of the string is between 1 and 50 characters, inclusive. 
Each character of the string is a lower-case letter of English alphabet.

Example

input

interview

output

wvtrniiee
 */
using System;
using System.Linq;

namespace CodingChallenge
{
    public class Q4
    {
        public void Driver()
        {
            string str = "interview";

            if (CheckStringLength(str))
            {
                Console.WriteLine("Length of the string should between 1 and 50 characters");
                Environment.Exit(0);
            }

            Console.WriteLine(RearrangeString(str));


        }
        public string RearrangeString(string str)
        {
            char[] arr = str.ToCharArray();
            arr = arr.OrderByDescending(c => c).ToArray();
            return String.Join("", arr);
        }

        public bool CheckStringLength(string str) {
            return (str.Length < 1 || str.Length > 50) ? true : false;
        }


    }
}
