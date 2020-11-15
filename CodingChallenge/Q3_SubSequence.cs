/*

Write a program that takes input of an integer N, followed by N more integers. 
The program then outputs the longest increasing subsequence present in that sequence. 
If more than 1 sequence exists, output the earliest one.

Example

Input
5
6 1 5 9 2

Output
1 5 9

*/

using System.Linq;
using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class Q3
    {
        public void Driver()
        {
            Console.WriteLine("Please enter a integer");
            int inputArraySize = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Please enter {0} integers sperated by space:", inputArraySize);
            string inputStringArray = Console.ReadLine().Trim();
            List<int> inputList = inputStringArray.Split(' ').Select(int.Parse).ToList();
            string longestStr = SubSequenceFinder(inputList);
            Console.WriteLine("Longest sub sequence for sequence [{0}] is [{1}]", inputStringArray, longestStr);
        }

        public string SubSequenceFinder(List<int> inputList)
        {
            List<List<int>> tempListList = new List<List<int>>();
            List<int> tempList = new List<int>();
            tempList.Add(inputList[0]);

            for (int i = 1; i <= inputList.Count - 1; i++)
            {
                if (inputList[i - 1] < inputList[i])
                {
                    tempList.Add(inputList[i]);
                }
                else
                {
                    tempListList.Add(tempList);
                    tempList = new List<int>();
                    tempList.Add(inputList[i]);
                }
            }
            tempListList.Add(tempList);
            List<int> tmpArr = tempListList.OrderByDescending(l => l.Count()).ToList()[0];
            return String.Join(" ", tmpArr);
        }
    }
}
