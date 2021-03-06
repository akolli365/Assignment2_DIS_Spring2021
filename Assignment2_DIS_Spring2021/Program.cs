﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                ///Checking if the array list can be shuffled using /2 
                if (nums.Length / 2 == n)
                {
                    //Storing the list length in variable
                    int[] result = new int[nums.Length];

                    //Adding the first half of the digits by seperating 0
                    //Like [2,5,1,3,4,7] will be [2,0,5,0,1,0]
                    //Later 0's will be replaced by other half of the digits

                    for (int i = 0; i < n; i++)
                    {
                        result[i * 2] = nums[i];
                    }
                    //Here 0's replacing with other half of the array
                    //[2,0,5,0,1,0] will be [2,3,5,4,1,7]
                    for (int j = 1; j < n + 1; j++)
                    {
                        result[(j * 2) - 1] = nums[n + j - 1];
                    }
                    //Joing the values in the array to string format
                    var result1 = string.Join(",", result);

                    Console.WriteLine("[" + result1 + "]");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int count = 0;
                int n = ar2.Length;

                //Looping over array and checkking each element if equal to zero
                //If not adding the values to index starting 0
                //if input length is 5 and input is 0,1,0,3,12
                //After this loop it will be 1,3,12 skipping zero's
                for (int i = 0; i < n; i++)
                {
                    if (ar2[i] != 0)
                        ar2[count++] = ar2[i];
                }

                //zeros will be added in the rest of the array by using it's size
                while (count < n)
                {
                    ar2[count++] = 0;
                }

                //Joining the array values into string var
                var result = string.Join(",", ar2);
                Console.WriteLine(result);

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            // int n = nums.Length;
            try
            {
                int ans = 0;
                Dictionary<int, int> pairs = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (!pairs.ContainsKey(nums[i]))
                    {
                        pairs[nums[i]] = 0;
                    }
                    pairs[nums[i]] += 1;
                }
                //Using n*(n+1)/2 to get the number of pairs

                foreach (var val in pairs.Keys)
                {
                    int temp = pairs[val] - 1;
                    ans += (temp * (temp + 1)) / 2;
                }
                Console.WriteLine(ans);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    //Checking if index n and n+1 equals to target

                    if (nums[i] + nums[i + 1] == target)
                    {
                        Console.WriteLine("[" + i + ", " + (i + 1) + "]");
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //Converting string to char array to match it with induces array
                if (s.Length == indices.Length)
                {
                    var values = s.ToCharArray();
                    StringBuilder sb = new StringBuilder();
                    //stroing the values of s into array using the index value, that stored in indices array
                    for (int i = 0; i < s.Length; i++)
                    {
                        values[indices[i]] = s[i];
                    }

                    //Appending the values in array to StringBuilder to form a string out of array
                    foreach (var str in values)
                    {
                        sb.Append(str.ToString());
                    }

                    Console.WriteLine(sb.ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            int size = 256;

            try
            {
                if (s1.Length == s2.Length)
                {
                    bool[] val1 = new bool[size];

                    for (int i = 0; i < size; i++)
                        val1[i] = false;

                    // initialize to -1 to store every value
                    int[] num = new int[size];

                    for (int i = 0; i < size; i++)
                        num[i] = -1;

                    for (int i = 0; i < s2.Length; i++)
                    {
                        //if current char is seen 
                        if (num[s1[i]] == -1)
                        {
                            //If current char is already seen
                            if (val1[s2[i]] == true)
                                return false;

                            // else Mark it as visisted
                            val1[s2[i]] = true;

                            // store the current char
                            num[s1[i]] = s2[i];
                        }

                        // If it's not the first visit of s1, check the previous appearence
                        else if (num[s1[i]] != s2[i])
                            return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                var dictionary = new SortedDictionary<int, List<int>>();

                //looping over the number of elements
                for (int j = 0; j < items.Length / 2; j++)
                {
                    //storing the id and score of each array
                    var id = items[j, 0];
                    var score = items[j, 1];

                    //Adding the score to dict if id is alreadya available
                    //If not adding id and score both in else condition(executes atleast once)
                    if (dictionary.ContainsKey(id))
                    {
                        dictionary[id].Add(score);
                    }
                    else
                    {
                        dictionary[id] = new List<int>();
                        dictionary[id].Add(score);
                    }

                }

                var keys = dictionary.Keys;
                var v = new int[keys.Count][];
                int i = 0;
                foreach (var student in dictionary)
                {
                    //storing the key into array
                    v[i] = new int[2];
                    v[i][0] = student.Key;
                    var sum = 0;
                    //Sorting the array
                    var temp = student.Value.ToArray();
                    Array.Sort(temp);
                    var k = 5;
                    //Taking values and sum them and also finding the average
                    for (int j = temp.Length - 1; j >= 0 && k > 0; j--)
                    {
                        sum += temp[j];
                        k--;
                    }
                    v[i][1] = sum / 5;
                    i++;
                }

                Console.Write("[[" + v[0][0] + "," + v[0][1] + "],");
                Console.WriteLine("[" + v[1][0] + "," + v[1][1] + "]]");
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                var set = new HashSet<int>();

                //Checking the condition and adding value to set
                //Run the loop until it becomes 1
                //If it ends in 1, the number is happy
                while (!set.Contains(n) && n != 1)
                {
                    set.Add(n);
                    var num = 0;


                    while (n != 0)
                    {
                        num = num + (int)Math.Pow(n % 10, 2);
                        n = n / 10;
                    }

                    n = num;
                }

                return n==1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                //write your code here.
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                //write your code here.

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
