using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.DynamicProgramming;

public static class CoinChange
{
    public static void RunTests()
    {
        var cases = new (int[] Coins, int Amount, int Expected)[]
        {
            ([1, 2, 5], 11, 3),
            ([2], 3, -1),
            ([1], 0, 0),
            ([1, 3, 4], 6, 2),
            ([2, 3], 1, -1),
            ([2, 3], 7, 3),
            ([7, 2, 4], 6, 2),
            ([], 1, -1)
        };

        foreach (var test in cases)
        {
            try
            {
                int actual = Change(test.Coins, test.Amount);
                Console.WriteLine(
                    $"[{string.Join(", ", test.Coins)}] / {test.Amount} => {actual}; expected {test.Expected}: " +
                    $"{(actual == test.Expected ? "PASS" : "FAIL")}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"[{string.Join(", ", test.Coins)}] / {test.Amount} => threw {exception.GetType().Name}; expected {test.Expected}: FAIL");
            }
        }
    }

    public static int Change(int[] coins, int amount)
    {
        if (amount == 0) return 0;
        if (coins == null || coins.Length == 0) return -1;

        Dictionary<int, int> cache = new Dictionary<int, int>();
        cache[0] = 0;

        int minCoinsNeeded = MinCoinsNeeded(amount, coins, cache);

        return minCoinsNeeded == int.MaxValue ? -1 : minCoinsNeeded;
    }

    public static int MinCoinsNeeded(int amount, int[] coins, Dictionary<int, int> cache)
    {
        if (cache.ContainsKey(amount)) return cache[amount];

        int minCoinsNeeded = int.MaxValue;

        foreach (int coin in coins)
        {
            if (coin <= amount)
            {
                minCoinsNeeded = Math.Min(MinCoinsNeeded(amount - coin, coins, cache), minCoinsNeeded);
            }
        }
        if (minCoinsNeeded != int.MaxValue)
        {
            minCoinsNeeded++;
            cache[amount] = minCoinsNeeded;
        }

        return minCoinsNeeded;

    }
}