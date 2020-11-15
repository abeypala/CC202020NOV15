/*
An array of integers a is called smooth if the absolute value of the difference between 
any two adjacent elements is less than or equal to 1. 
You are given an array a. 
Check whether it is smooth and output "YES" if it is, or "NO" if it is not (quotes for clarity only).

The first line of the input contains an integer N - the number of elements in the array. 1 <= N <= 10.
The second line of the input contains N integers - the elements of the array, 
separated with single spaces. 1 <= ai <= 10.

Example

input

5
3 4 4 5 4

output

YES

input

4
1 1 8 2

output

NO
 
*/

using System.Linq;
using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class Q2
    {
        public void Driver()
        {
            Console.WriteLine("Please enter number of elements in a array (1 <= N <= 10) :");
            int inputArraySize = int.Parse(Console.ReadLine().Trim());

            if (CheckArraySize(inputArraySize))
            {
                Console.WriteLine("Number should be 1 or greater and less than or equal 10");
                Environment.Exit(0);
            }


            Console.WriteLine("Please enter {0} elements for the array sperated by space:", inputArraySize);
            Console.WriteLine("(Elements should be any integer 1 to 10 inclusive)");
            String inputStringArray = Console.ReadLine().Trim();         
            List<int> inputList = inputStringArray.Split(' ').Select(int.Parse).ToList();

            if(CheckArrayElements(inputList))
            {
                Console.WriteLine("Elements should be any integer 1 to 10 inclusive");
                Environment.Exit(0);
            }

            if (CheckArrayElementCount(inputList, inputArraySize))
            {
                Console.WriteLine("Number of elements entered not match with actual");
                Environment.Exit(0);
            }


            Console.WriteLine(CheckArraySmooth(inputList));


        }
        public string CheckArraySmooth(List<int> inputList)
        {
            string notSmoothflag = "YES";
            for (int i = 1; i < (inputList.Count - 1); i++)
            {
                if (Math.Abs(inputList[i - 1] - inputList[i]) > 1 || Math.Abs(inputList[i + 1] - inputList[i]) > 1)
                {
                    notSmoothflag = "NO";
                }

            }
            return notSmoothflag;
        }
        public bool CheckArraySize(int inputArraySize)
        {
            return (inputArraySize < 1 || inputArraySize > 10) ? true : false;
        }

        public bool CheckArrayElements(List<int> arr)
        {
            return arr.Where(e=> e < 1 || e > 10).ToList().Count>1;
        }

        public bool CheckArrayElementCount(List<int> arr, int arrSize)
        {
            return (arr.Count != arrSize)?true:false;
        }

    }
}
