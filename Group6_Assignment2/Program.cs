using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_Fall2020
{
    class Program
    {


        static void Main(string[] args)
        {
            /*Console.WriteLine("Question 1");
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
            */
            Console.WriteLine("Question 7");
            int[] numbers = { 0, 1, 3, 50, 75 };
            //int[] numbers = { };
            //int[] numbers = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99};
            int lower = 0;
            int upper = 99;
            List<String> ResultList = Ranges(numbers, lower, upper);
            //Write code to print list here
            Console.WriteLine();
            printOutput(ResultList);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 8");
            //string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            string[] names = new string[] { "gta", "gta(1)", "gta", "avalon" };
            //string[] names = new string[] { "onepiece", "onepiece(1)", "onepiece(2)", "onepiece(3)", "onepiece" };
            //string[] names = new string[] {"wano", "wano", "wano", "wano"};
            string[] namesResult = UniqFolderNames(names);
            //Write code to print your result here
            Console.WriteLine();
            printOutput(namesResult);
            
            Console.ReadKey(true);

        }

        private static void printOutput(List<string> ResultList)
        {
            Console.Write("Output: [");
            for(int i = 0; i < ResultList.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("\"");
                }
                Console.Write(ResultList[i]);
                if(i<ResultList.Count - 1)
                {
                    Console.Write("\",\"");
                }
                if (i == ResultList.Count - 1)
                {
                    Console.Write("\"");
                }
            }
            Console.Write("]");
        }

        private static void printOutput(string[] ResultList)
        {
            Console.Write("Output: [");
            for (int i = 0; i < ResultList.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("\"");
                }
                Console.Write(ResultList[i]);
                if (i < ResultList.Length - 1)
                {
                    Console.Write("\",\"");
                }
                if (i == ResultList.Length - 1)
                {
                    Console.Write("\"");
                }
            }
            Console.Write("]");
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

        public static int[] SortedSquares(int[] A)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }

            return new int[] { };
        }


        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        }
        public static List<String> Ranges(int[] numbers, int lower, int upper)
        {
            List<String> res = new List<String>();
            // two pointers,i & j, for loop j (check numbers.length > 2), if [j] == [j-1]+1 continue, else handle
            // left, right, if l == r, add only l. else add l->r.
            // handle first and last.
            try { 
                
                int n = numbers.Length;
                // edge cases
                if (n == 0)
                {
                    addRange(res, lower, upper);
                    return res;
                }

                // first one
                if (lower < numbers[0])
                {
                    addRange(res, lower, numbers[0] - 1);
                }
    
                // body
                if (n >= 2)
                {
                    for (int i = 1; i < n; i++)
                    {
                        long diff = (long)numbers[i] - (long)numbers[i - 1];
                        if (diff == 1) continue;
                        // stop, check value
                        if (diff >= 2)
                        {
                            addRange(res, numbers[i - 1] + 1, numbers[i] - 1);
                        }
                    }
                }
    
                // last
                if (numbers[n - 1] < upper)
                {
                    addRange(res, numbers[n - 1] + 1, upper);
                }

       
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred inside Ranges() method: " + e.Message + " " + e.StackTrace);
            }
            
            return res;
        }
        public static string[] UniqFolderNames(string[] names)
        {
            
            if(names == null || names.Length == 0)
            {
                return new string[] { };
            }
            
            string[] res = new string[names.Length];
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            try
            {
                for(int i = 0; i <names.Length; i++)
                {
                    string key = names[i];
                    if (key.EndsWith(")"))
                    {
                        key = key.Substring(0, key.Length - 3);
                    }
                    if (dict.ContainsKey(key))
                    {
                        int count = dict[key];
                        res[i] = key + "(" + Convert.ToString(count + 1) + ")";
                        dict[key] = count + 1;
                    }
                    else
                    {
                        res[i] = names[i];
                        dict.Add(key,0);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred inside UniqFolderNames() method: " + e.Message + " " + e.StackTrace);
            }
            return res;
        }

        public static void addRange(List<String> res, int l, int r)
        {
            if (l == r)
            {
                res.Add(l + "");
            }
            else if (l < r)
            {
                res.Add(l + "->" + r);
            }
        }


    }
}





