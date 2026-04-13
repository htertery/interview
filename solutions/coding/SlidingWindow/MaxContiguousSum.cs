using System;

namespace Coding.SlidingWindow;

public class MaxContiguousSum
{
    public static void RunTests()
    {
        Console.WriteLine("=== MaxContiguousSum ===");

        // Test 1: Basic case
        var r1 = GetContiguousSum([2, 1, 5, 1, 3, 2], 3);
        Console.WriteLine($"Test 1: {r1} (expected 9) {(r1 == 9 ? "PASS" : "FAIL")}");

        // Test 2: k=2
        var r2 = GetContiguousSum([2, 3, 4, 1, 5], 2);
        Console.WriteLine($"Test 2: {r2} (expected 7) {(r2 == 7 ? "PASS" : "FAIL")}");

        // Test 3: Single element
        var r3 = GetContiguousSum([1], 1);
        Console.WriteLine($"Test 3: {r3} (expected 1) {(r3 == 1 ? "PASS" : "FAIL")}");

        // Test 4: k equals array length
        var r4 = GetContiguousSum([1, 2, 3], 3);
        Console.WriteLine($"Test 4: {r4} (expected 6) {(r4 == 6 ? "PASS" : "FAIL")}");

        // Test 5: Negative numbers
        var r5 = GetContiguousSum([-1, -2, -3, -4], 2);
        Console.WriteLine($"Test 5: {r5} (expected -3) {(r5 == -3 ? "PASS" : "FAIL")}");

        // Test 6: Mixed positive and negative
        var r6 = GetContiguousSum([4, -1, 2, 1, -5, 4], 3);
        Console.WriteLine($"Test 6: {r6} (expected 5) {(r6 == 5 ? "PASS" : "FAIL")}");
    }

    /// <summary>
    /// Returns sum the max sum of any contiguous subarray
    /// </summary>
    /// <param name="numbers">Numbers</param>
    /// <param name="k">Window</param>
    /// <returns>Max sum of any contiguous subarray</returns>
    public static int GetContiguousSum(int[] numbers, int k)
    {
        if(k < 1)
        {
            throw new ArgumentException("Window size must be > 1");
        }
        if(numbers == null || numbers.Length < k)
        {
            throw new ArgumentException("Invalid array");
        }

        int maxSum = numbers[0];
        
        //calclate sum of first k elements
        for(int i = 1; i<k; i++)
        {
            maxSum+=numbers[i];
        }

        int windowLastIndex = k;
        int tempSum;
        while(windowLastIndex < numbers.Length-1)
        {
            tempSum = maxSum - numbers[windowLastIndex - k] + numbers[windowLastIndex+1];
            if(maxSum < tempSum){
                maxSum = tempSum;
            }
            windowLastIndex++;
        }

        return maxSum;
    }
}