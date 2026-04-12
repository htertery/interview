using System;
using System.Collections.Generic;

namespace Coding.ArraysAndHashing;

public class TargetSum
{
    public static void RunTests()
    {
        Console.WriteLine("=== TargetSum ===");

        var basicPair = GetPairsForTargetSum([3, 5, 7, 12], 17);
        Console.WriteLine("Basic pair");
        foreach (var p in basicPair) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var duplicates = GetPairsForTargetSum([5, 5, 5], 10);
        Console.WriteLine("Duplicate values");
        foreach (var p in duplicates) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var multiple = GetPairsForTargetSum([1, 2, 3, 4, 5], 6);
        Console.WriteLine("Multiple pairs");
        foreach (var p in multiple) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var noPairs = GetPairsForTargetSum([1, 2, 3], 10);
        Console.WriteLine("No pairs found");
        foreach (var p in noPairs) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var negatives = GetPairsForTargetSum([-1, 6, 3, 2], 5);
        Console.WriteLine("Negative numbers");
        foreach (var p in negatives) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var empty = GetPairsForTargetSum([], 5);
        Console.WriteLine("Empty array");
        foreach (var p in empty) Console.WriteLine($"  ({p.Key}, {p.Value})");

        var single = GetPairsForTargetSum([5], 10);
        Console.WriteLine("Single element");
        foreach (var p in single) Console.WriteLine($"  ({p.Key}, {p.Value})");
    }

    public static Dictionary<int, int> GetPairsForTargetSum(int[] numbers, int targetSum)
    {
        //[12, 3, 5, 7, 12, 5], target 
        HashSet<int> hashSet = new HashSet<int>();
        Dictionary<int, int> pairs = new Dictionary<int, int>();

        int e;
        for (int i = 0; i < numbers.Length; i++)
        {
            e = numbers[i];

            if (hashSet.Contains(targetSum - e))
            {
                if (!pairs.ContainsKey(targetSum - e) && !pairs.ContainsKey(e))
                {
                    pairs.Add(e, targetSum - e);
                }
            }

            if (!hashSet.Contains(e))
            {
                hashSet.Add(e);
            }

        }

        return pairs;
    }
}