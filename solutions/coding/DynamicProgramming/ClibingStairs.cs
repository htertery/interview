using System;
using System.Collections.Generic;

namespace Coding.DynamicProgramming;
public class ClimbingStairs
{
   public static void RunTests()
    {
        Console.WriteLine("Climb Stais");
        var cases = new (int n, int expected)[]
        {
            (1, 1),  // Base case
            (2, 2),  // Base case
            (3, 3),  // 1+1+1, 1+2, 2+1
            (4, 5),
            (5, 8),
            (10, 89)
        };

        foreach (var test in cases)
        {
            int actual = ClimbStairs(test.n);
            Console.WriteLine(
                $"n={test.n}: got {actual}, expected {test.expected} " +
                $"{(actual == test.expected ? "PASS" : "FAIL")}");
        }
    }

    public static int ClimbStairs(int n)
    {
        Dictionary<int,int> cache = new Dictionary<int,int>();
        return ClimbStairsRec(n,cache);
    }

    public static int ClimbStairsRec(int n, Dictionary<int, int> cache)
    {
        if(n==1) return 1;
        if(n==2) return 2;
        if(cache.ContainsKey(n)) return cache[n];

        cache[n] = ClimbStairsRec(n-1, cache) + ClimbStairsRec(n-2, cache);
        return cache[n];
    }
    
}