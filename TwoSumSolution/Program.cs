using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 17;

        int[] result = TwoSum(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }
            numToIndex[nums[i]] = i;
        }

        throw new ArgumentException("No solution found");
    }
}
