/*
A Fibonacci-like sequence is a sequence of integers a1, a2, ... for which an = an-1+an-2 for all n > 2. 
You are given the first two elements of the sequence a1 and a2, and the 1-based index n. 
Output the n-th element of the sequence.

The input data consists of a single line which contains integers a1, a2 and n separated by single spaces. 
0 < a1, a2, n <= 10.

Example

input

1 2 3

output

3
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    public class Q1
    {
        public void Driver()
        {
            Console.WriteLine("Please enter first two numbers of the sequence followed by Nth index seperated by spaces");
            Console.WriteLine("First two numbers are greater than 0 and Nth number is less than or equal to 10");
            string inputStr = Console.ReadLine().Trim();   //string inputStr = "1 2 5";

            List<int> inputList = inputStr.Split(' ').Select(int.Parse).ToList();
            if (inputList[0] <= 0 || inputList[1] <= 0 || inputList[2] > 10)
            {
                Console.WriteLine("First two numbers are greater than 0 and Nth number is less than or equal to 10");
            }
            int nthValue = FibonacciLike(inputList[0], inputList[1], inputList[2]);
            Console.WriteLine("Nth number of sequent starting {0},{1} is {2}", inputList[0], inputList[1], nthValue);

        }

        public int FibonacciLike(int firstInt, int secondInt, int nthInt)
        {
            int tempInt = 0;

            for (int i = 1; i < (nthInt - 1); i++)
            {
                tempInt = firstInt + secondInt;
                firstInt = secondInt;
                secondInt = tempInt;
            }
            return tempInt;
        }
    }
}
