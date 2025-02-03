using System;

public class Solution
{
    public static  int[] PlusOne(int[] digits)
    {
         int n = digits.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] result = new int[n + 1];
        result[0] = 1;
        return result;
    }

    public static void Main()
    {
        int[] digits1 = { 1, 2, 3 };
        int[] digits2 = { 4, 3, 2, 1 };
        int[] digits3 = { 9 };

        Console.WriteLine($"{string.Join(",", PlusOne(digits1))}"); // Output: 1,2,4
        Console.WriteLine($"{string.Join(",", PlusOne(digits2))}"); // Output: 4,3,2,2
        Console.WriteLine($"{string.Join(",", PlusOne(digits3))}"); // Output: 1,0
    }
}
