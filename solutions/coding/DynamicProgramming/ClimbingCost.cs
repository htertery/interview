using System;
using System.Collections.Generic;

namespace Coding.DynamicProgramming;

public static class ClimbingCost
{
    public static void RunTests()
    {
        var cases = new (int[] Costs, int Expected)[]
        {
            ([10, 15, 20], 15),
            ([1, 100, 1, 1, 1, 100, 1, 1, 100, 1], 6),
            ([1, 2], 1),
            ([0, 0], 0),
            ([5, 1, 2], 1)
        };

        Console.WriteLine("Climbing Cost");

        foreach (var test in cases)
        {
            int actual = MinClimbCost(test.Costs);
            Console.WriteLine(
                $"[{string.Join(", ", test.Costs)}] => {actual}; expected {test.Expected}: " +
                $"{(actual == test.Expected ? "PASS" : "FAIL")}");
        }
    }

    public static int MinClimbCost(int [] costs)
    {
        if(costs.Length == 0) return 0;

        int prev1 = costs[0];
        int prev2 = costs[1];

        int minCost = prev2;

        for(int i = 2 ; i<costs.Length; i++)
        {
            minCost = Math.Min(prev1,prev2)+costs[i];
            prev1 = prev2;
            prev2 = minCost;
        }

        return Math.Min(prev2,prev1);
    }
}