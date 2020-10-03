using System;
using System.Collections.Generic;
using System.Linq;

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
            int[] arr = { 1, 3, 5, 4, 7 };
            int p = arr.Length;
            Console.WriteLine("Length = " +
                               lenOfLongIncSubArr(arr, p));

            Console.WriteLine("Question 3");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 5 };
            int q = 6;
            PrintTwoParts(array2, q);

            Console.WriteLine();
            Console.WriteLine("Question 4");
            int[] array3 = new int[] { -4, -1, 0, 3, 10 };
            int[] result2 = SortedSquares(array3);
            Console.WriteLine("Input Array elements are: [" + string.Join(',', array3.ToList()) + "]");
            Console.WriteLine("Sorted Squared Array elements are: [" + string.Join(',', result2.ToList()) + "]");
            //Write code to print the result array here

            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            Console.WriteLine("Input Array 1 elements are: [" + string.Join(',', nums1.ToList()) + "]");
            Console.WriteLine("Input Array 2 elements are: [" + string.Join(',', nums2.ToList()) + "]");
            Console.WriteLine("Intersection Array elements are: [" + string.Join(',', intersect1.ToList()) + "]");
            //Write code to print the result array here


            Console.WriteLine("Question 6");
            int[] array = new int[] { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine("Input Array elements are: [" + string.Join(',', array.ToList()) + "]");
            Console.WriteLine(UniqueOccurrences(array));

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
            for (int i = 0; i < ResultList.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("\"");
                }
                Console.Write(ResultList[i]);
                if (i < ResultList.Count - 1)
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

        // ***** The first triangle has more complexity, but also more capability. I found that having more than 75 *'s                                 *****
        // ***** would go to the next line in the command prompt, therefore making the output less clean. So the limitation here is at most 75 layers.  *****
        // ***** I believe that because there are two loops at O(n) , that the complexity of this algorithm is therefore O2(n)                          *****

        public static void PrintPatternAnyComplexity(int n)
        {
            Console.Write("Please enter a number less than 76:");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                string[] layers = new string[75];

                for (int i = 1; i <= value_of_input; i++)
                {
                    layers[i-1] = string.Concat(Enumerable.Repeat("*", i));
                }

                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine(layers[i]);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
                throw;
            }
        }

        // ***** The second triangle is less complex and of linear complexity. It is an equilateral triangle. *****
        // ***** This is similar to the triangle from assignment 1, but with slightly more layers.            *****
        // ***** A very simple O(n) triangle.                                                                 *****
        public static void PrintPatternLinearComplexity(int n)
        {
            Console.Write("Please enter a number between 1 and 7: ");
            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);

                string[] layers = { "      *", "     ***", "    *****", "   *******", "  *********", " ***********", "*************" };

                // Iterate through the array using a For Loop
                for (int i = 0; i < value_of_input; i++)
                {
                    // layers[i] = layers;
                    Console.WriteLine(layers[i]);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }
        }

        // *** For this method, len is incremented if i > than i -1.                      ***;
        // *** Otherwise, the max length is = 1.                                          ***;
        // *** Max is made equal to len if less than len, which it would be.              ***;
        // *** Max is then printed as the largest subarray or 1.                          ***;
        // *** This method confines itself within o(n) with help from 'Geeksforgeeks.org' ***;

        public static int lenOfLongIncSubArr(int[] arr,
                                                 int p)
        {

            int max = 1, len = 1;
            // traverse the array from the 2nd element
            for (int i = 1; i < p; i++)
            {
                // if current element if greater than
                // previous element, then this element
                // helps in building up the previous
                // increasing subarray encountered
                // so far
                if (arr[i] > arr[i - 1])
                    len++;
                else
                {
                    // check if 'max' length is less
                    // than the length of the current
                    // increasing subarray. If true,
                    // than update 'max'
                    if (max < len)
                        max = len;
                    // reset 'len' to 1 as from this
                    // element again the length of the
                    // new increasing subarray is being
                    // calculated
                    len = 1;
                }
            }
            // comparing the length of the last
            // increasing subarray with 'max'
            if (max < len)
                max = len;
            // required maximum length
            return max;
        }


        // *** Originally in reading this I thought of spliting the array in only two halves, in which case one could just compare the sum by taking the length of the array/2.               ***
        // *** However after realizing this required more logic than that to try all possible combinations (without reordering), I researched more on 'geeksforgeeks.org'.                                           ***  
        // *** In this function the left side is summed first using a += assignment loop. The right side picks up and interates where I left off + 1 to assign and sum the right side using j ***
        // *** If at any point the leftsum is equal to the rightsum, the first method returns i. Else it returns -1.                                                                          ***
        // *** When the second method see's the first method has returned i, it prints the two subarrays.                                                                                     ***
        // *** Although this function uses a loop within a loop,Both only go as far through the array as needed to check each pair. The second method prints the arrays                       ***
        // *** which should be directly proprotional to the size of the array as well.                                                                                                        ***
        // *** Therefore I believe this example to be o(n) or o2(n).                                                                                                                          ***  
        // *** With only a few possible outcomes, corner cases should be minimal.                                                                                                             ***          

        static int findSplitPoint(int[] array2, int q)
        {

            int leftSum = 0;

            // traverse array element
            for (int i = 0; i < q; i++)
            {

                // add current element to left Sum
                leftSum += array2[i];

                // find sum of rest array
                // elements (rightSum)
                int rightSum = 0;

                for (int j = i + 1; j < q; j++)
                    rightSum += array2[j];

                // split point index
                if (leftSum == rightSum)
                    return i + 1;
            }

            // if it is not possible to  
            // split array into two parts
            return -1;
        }

        // Prints two parts after finding  
        // split point using findSplitPoint()
        static void PrintTwoParts(int[] array2, int q)
        {

            int splitPoint = findSplitPoint(array2, q);

            if (splitPoint == -1 || splitPoint == q)
            {
                Console.Write("Not Possible");
                return;
            }

            for (int i = 0; i < q; i++)
            {
                if (splitPoint == i)
                    Console.WriteLine();

                Console.Write(array2[i] + " ");
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
                        if (!dict.ContainsKey(num))
                        {
                            dict.Add(num, 0);
                        }
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
            List<String> res = new List<String>();
            // two pointers,i & j, for loop j (check numbers.length > 2), if [j] == [j-1]+1 continue, else handle
            // left, right, if l == r, add only l. else add l->r.
            // handle first and last.
            try
            {

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

            if (names == null || names.Length == 0)
            {
                return new string[] { };
            }

            string[] res = new string[names.Length];
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                for (int i = 0; i < names.Length; i++)
                {
                    string key = "";
                    int num = 0;
                    string wholekey = names[i];
                    // check if bracket already present in file name
                    if (wholekey.EndsWith(")"))
                    {
                        int startBracket = wholekey.IndexOf("(");
                        int endBracket = wholekey.IndexOf(")");                        
                        key = wholekey.Substring(0, startBracket);                        
                        num = Convert.ToInt32(wholekey.Substring(startBracket + 1, endBracket - startBracket - 1));
                        
                    }
                    else
                    {
                        key = names[i];
                    }
                    if (dict.ContainsKey(key))
                    {
                        int count = dict[key];

                        if (wholekey.EndsWith(")"))
                        {
                            // if bigger number within bracket
                            if (count < num)
                            {
                                res[i] = names[i];
                            }
                            else
                            {
                                res[i] = key + "(" + Convert.ToString(count + 1) + ")";
                            }
                        }
                        else {
                            res[i] = key + "(" + Convert.ToString(count + 1) + ")";
                        }
                        dict[key] = count + 1;
                    }
                    else
                    {
                        res[i] = names[i];
                        dict.Add(key, 0);
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





