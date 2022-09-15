using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://leetcode.com/problems/single-number/
             * 
             * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
             * You must implement a solution with a linear runtime complexity and use only constant extra space.
             * 
             * Example 1:
             * Input: nums = [2,2,1]
             * Output: 1
             * 
             * Example 2:
             * Input: nums = [4,1,2,1,2]
             * Output: 4
             * 
             * Example 3:
             * Input: nums = [1]
             * Output: 1
             * 
             * Constraints:
             * 1 <= nums.length <= 3 * 104
             * -3 * 104 <= nums[i] <= 3 * 104
             */

            var nums = new int[] { 2, 2, 1 };

            int ans = 0;

            foreach (int num in nums)
            {
                ans ^= num;
            }

            Console.WriteLine(ans);
        }
    }
}
