using System;

namespace Coding.DynamicProgramming;

// [12, 8, 0, 1, 11, 21, 4]
// [12, 12, 12, 13,23,34]
public static class HouseRobber
{
    public static void RunTests()
    {
        var cases = new (int[] Loots, int Expected)[]
        {
            ([], 0),
            ([5], 5),
            ([2, 7], 7),
            ([1, 2, 3, 1], 4),
            ([2, 7, 9, 3, 1], 12),
            ([2, 1, 1, 2], 4),
            ([0, 0, 0], 0)
        };

        Console.WriteLine("Rhouse Robber");

        foreach (var test in cases)
        {
            int actual = MaxLoot(test.Loots);
            Console.WriteLine(
                $"[{string.Join(", ", test.Loots)}] => {actual}; expected {test.Expected}: " +
                $"{(actual == test.Expected ? "PASS" : "FAIL")}");
        }
    }

    public static int MaxLoot(int[] loots)
    {
        int n = loots.Length;

        if(n==0) return 0;

        int t1 = loots[0];
        if(n == 1) return t1;

        int t2 = Math.Max(t1, loots[1]);  
        if(n == 2) return t2;       

        int temp = t2;

        for(int i = 2; i < n; i++)
        {
            temp = t2;
            t2 = Math.Max(t2,t1+loots[i]);
            t1 = temp;
        } 

        return Math.Max(t1,t2);  
    }
}