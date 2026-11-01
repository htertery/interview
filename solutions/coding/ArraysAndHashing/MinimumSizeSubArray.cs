using System;
using System.Collections.Generic;

namespace Coding.ArraysAndHashing;

public static class MinimumSizeSubArray
{
    public static void RunTests()
    {
        Console.WriteLine("Running GetMinSizeOfSubArray Tests...\n");

        ExecuteTest("Test 1: Standard Case", new int[] { 2, 3, 1, 2, 4, 3 }, 7, 2);
        ExecuteTest("Test 2: No Solution Possible", new int[] { 1, 1, 1, 1 }, 11, 0);
        ExecuteTest("Test 3: Single Element Match", new int[] { 1, 4, 4 }, 4, 1);
        ExecuteTest("Test 4: Entire Array Needed", new int[] { 1, 2, 3, 4 }, 10, 4);
        ExecuteTest("Test 5: Empty Array", new int[] { }, 7, 0);
        ExecuteTest("Test 6: Target is Zero", new int[] { 1, 2, 3 }, 0, 0);
    }

    private static void ExecuteTest(string testName, int[] array, int targetSum, int expected)
    {
        int result = GetMinSizeOfSubArray(array, targetSum);
        if (result == expected)
        {
            Console.WriteLine($"[PASS] {testName}");
        }
        else
        {
            Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Got: {result}");
        }
    }

    private static int GetMinSizeOfSubArray(int[] array, int targetSum)
    {
        if (array == null || array.Length == 0) return 0;

        // [2,3,1,2,4,3], 7

        int size = array.Length + 1;

        int left = 0;
        int right = 0;
        int sum = array[0];

        while (left < array.Length)
        {
            if (sum >= targetSum)
            {
                size = Math.Min(size, right - left + 1);
                sum -= array[left];
                left++;
            }

            if(right < array.Length - 1)
            {
                sum += array[right];
                right++;
            }
        }

        return size;
    }
}