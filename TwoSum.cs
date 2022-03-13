using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace leetCodeSubmissions
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    //    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //    You can return the answer in any order.
    //    Example 1:

    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    public static class TwoSum
    {

        public static int[] TwoSumFunc(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var firstIndex = nums[i];
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (j != i && nums[j] + firstIndex == target)
                    {
                        Console.WriteLine($"Success {i}, {j}");
                        return new[] { i, j };
                    }
                }

            }           
            Console.WriteLine("Not possible to find indices from this array.");
            return new int[]{0, 0};
        }
    }
}
