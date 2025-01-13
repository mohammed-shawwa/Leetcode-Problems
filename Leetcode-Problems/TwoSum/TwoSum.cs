using System;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };

        return new int[] { };
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            Console.WriteLine($"Numbers: {nums[result[0]]}, {nums[result[1]]}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
