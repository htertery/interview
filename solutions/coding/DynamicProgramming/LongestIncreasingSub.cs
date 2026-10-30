using System;
using System.Collections.Generic;

namespace Coding.DynamicProgramming;

public static class LongestIncreasingSub
{
    public static int RunTests()
    {
        Console.WriteLine("Longest Increasing Sub");
        var testCases = new (string Name, int[] Input, int Expected)[]
        {
            // Edge Cases
            ("Null array", null, 0),
            ("Empty array", Array.Empty<int>(), 0),
            ("Single element", new int[] { 42 }, 1),

            // Standard Examples
            ("Standard LeetCode example", new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4), // [2, 3, 7, 101] or [2, 5, 7, 101]
            ("Standard sequence with small numbers", new int[] { 0, 1, 0, 3, 2, 3 }, 4), // [0, 1, 2, 3]

            // Duplicates & Monotonic Orders
            ("All identical elements (strictly increasing)", new int[] { 7, 7, 7, 7, 7 }, 1),
            ("Strictly decreasing sequence", new int[] { 5, 4, 3, 2, 1 }, 1),
            ("Strictly increasing sequence", new int[] { 1, 2, 3, 4, 5 }, 5),
            ("Duplicates within increasing sequence", new int[] { 1, 3, 6, 7, 9, 4, 10, 5, 6 }, 6), // [1, 3, 4, 5, 6] -> 5 or [1, 3, 6, 7, 9, 10] -> 6

            // Negative Numbers & Alternating
            ("Negative numbers included", new int[] { -2, -1, -5, 0, 3, -1 }, 4), // [-2, -1, 0, 3]
            ("Alternating high and low values", new int[] { 1, 10, 2, 9, 3, 8, 4, 7 }, 5), // [1, 2, 3, 4, 7]
            ("Large step jump", new int[] { 100, 1, 2, 3, 101 }, 4) // [1, 2, 3, 101]
        };

        int passed = 0;
        int failed = 0;

        foreach (var (name, input, expected) in testCases)
        {
            try
            {
                int actual = GetLongestIncreasingSubSize(input);
                if (actual == expected)
                {
                    Console.WriteLine($"[PASS] {name}: Expected {expected}, Got {actual}");
                    passed++;
                }
                else
                {
                    Console.WriteLine($"[FAIL] {name}: Expected {expected}, Got {actual}");
                    failed++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {name}: Threw {ex.GetType().Name} - {ex.Message}");
                failed++;
            }
        }

        Console.WriteLine($"\nResults: {passed} passed, {failed} failed out of {testCases.Length} tests.");
        return failed == 0 ? 0 : 1;
    }

    public static int GetLongestIncreasingSubSize(int [] array)
    {
        if(array == null || array.Length == 0) return 0;

        int[] dp = new int [array.Length];
        for(int i  = 0 ; i < array.Length; i++)
        {
            dp[i] = 1;
        }

        int max = 1;
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if (array[j] < array[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j]+1);
                }
                
            }
            if(dp[i] > max) {
                Console.Write(array[i]);
                max = dp[i];
            }
        }

        return max;
    }
}