using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Assignment2_Fall2020
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int n = 7;
            PrintPatternAnyComplexity(n);
            PrintPatternLinearComplexity(n);


            Console.WriteLine("Question 2");
            int[] array1 = new int[] { 1, 3, 5, 4, 7 };
            int result = LongestSubSeq(array1);
            Console.WriteLine(result);

            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5 };
            PrintTwoParts(array2);


            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            int[] result2 = SortedSquares(array3);
            //Write code to print the result array here

            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            //Write code to print the result array here


            Console.WriteLine("Question 6");
            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine(UniqueOccurrences(arr));

            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            List<String> ResultList = Ranges(numbers, lower, upper);
            //Write code to print list here

            Console.WriteLine("Question 8");
            string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            string[] namesResult = UniqFolderNames(names);
            //Write code to print your result here


        }

        public static void PrintPatternAnyComplexity(int n)

        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void PrintPatternLinearComplexity(int n)

        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static int LongestSubSeq(int[] nums)
        {
            try
            {
                //write your code here 
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
        public static void PrintTwoParts(int[] array2)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.
         * 
         * Example 1:
         * Input: [-4,-1,0,3,10]
         * Output: [0,1,9,16,100]
         * 
         * Example 2:
         * Input: [-7,-3,2,3,11]
         * Output: [4,9,9,49,121]
         *
         * Note:
         * 1 <= A.length <= 10000
         * -10000 <= A[i] <= 10000
         * A is sorted in non-decreasing order.
         * The time complexity of the method should not exceed O(n)
         */
        public static int[] SortedSquares(int[] A)
        {
            int[] squaredArray = null;
            try
            {
                if (A != null) {
                    squaredArray = new int[A.Length];
                    //iterate over given array and square all numbers
                    for (int i = 0; i < A.Length; i++)
                    {
                        squaredArray[i] = A[i] * A[i];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred inside SortedSquares() method: " + e.Message + " " + e.StackTrace);
            }
            return squaredArray;
        }

        /*
         * Given two arrays, write a function to compute their intersection. 
         * Example 1:
         * Input: nums1 = [4,2,2,4], nums2 = [2,2]
         * Output: [2,2]
         * Example 2:
         * Input: nums1 = [3,6,2], nums2 = [6,3,6,7,3]
         * Output: [3,6]
         *
         * Note:
         * Each element in the result should appear as many times as it shows in both arrays.
         * The result can be in any order.
         *
         * Note: Algorithm’s runtime complexity must be in the order of O(n).
         * Hint : You can make use of a dictionary to obtain the required time complexity.
         *
         */
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int[] output = null;
            try
            {
                if (nums1 != null && nums2 != null)
                {
                    //map 2nd array into dictionary
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    foreach(int num in nums2)
                    {
                        dict.Add(num, 0);
                    }
                    //iterate over 1st array, if a given number from 1st array is in the 2nd array (dict), then add it to the output 
                    List<int> intersect = new List<int>();
                    foreach (int num in nums1)
                    {
                        if (dict.ContainsKey(num))
                        {
                            intersect.Add(num);
                        }
                    }
                    output = intersect.ToArray();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("An exception occurred inside Intersect() method: " + e.Message + " " + e.StackTrace);
            }

            return output;
        }

        /* Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.
         * Example 1: 
         * Input: arr = [1,2,2,1,1,3]
         * Output: true
         * Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
         * Example 2:
         * Input: arr = [1,2]
         * Output: false
         * Example 3:
         * Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
         * Output: true
         * Note: The time complexity of the method should not exceed O(n)
         * Hint: Make use of dictionaries to attain the time complexity.
         */
        public static bool UniqueOccurrences(int[] arr)
        {
            bool output = true;
            try
            {
                if (arr != null)
                {
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    //convert array into dictionary and count occurences of each array member
                    foreach(int i in arr)
                    {
                        if (dict.ContainsKey(i))
                        {
                            dict[i] = ++dict[i];
                        } else
                        {
                            dict.Add(i, 1);
                        }
                    }
                    //iterate over occurences of each array element in the dictionary
                    //if value of occurences is unique - add to the dictionary, 
                    //if value repeats - break out of the loop and return false
                    Dictionary<int, int> dict2 = new Dictionary<int, int>(); 
                    foreach(int occurence in dict.Values)
                    {
                        if (dict2.ContainsKey(occurence))
                        {
                            output = false;
                            break;
                        } else
                        {
                            dict2.Add(occurence, 0);
                        }
                    }

                } else
                {
                    output = false;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An exception occurred inside UniqueOccurrences() method: " + e.Message + " " + e.StackTrace);
            }
            return output;
        }

        public static List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }

    }
}





