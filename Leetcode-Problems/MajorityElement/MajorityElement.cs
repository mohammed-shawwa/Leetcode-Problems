using System;
public class MajorityElementClass
{
    public static int MajorityElement(int[] nums)
    {
        int value = 0, count = 0;

        foreach (int num in nums)
        {
            if (count == 0) value = num;
            
            count += (num == value) ? 1 : -1;
        }

        return value;
    }

    public static void Main()
    {
        int[] nums = { 2, 1, 1, 1 };

        int result = MajorityElement(nums);
        
       Console.WriteLine($"Result: {result}");
    }
}