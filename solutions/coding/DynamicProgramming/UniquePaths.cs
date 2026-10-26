using System;
using System.Collections.Generic;

namespace Coding.DynamicProgramming;

public static class UniquePaths
{
    public static void RunTests()
    {
        var cases = new (int Rows, int Columns, int Expected)[]
        {
            (1, 1, 1),
            (1, 5, 1),
            (5, 1, 1),
            (2, 2, 2),
            (3, 2, 3),
            (3, 7, 28)
        };

        foreach (var test in cases)
        {
            int actual = HowManyUniquePathsTo(test.Rows, test.Columns);
            Console.WriteLine(
                $"{test.Rows}x{test.Columns} => {actual}; expected {test.Expected}: " +
                $"{(actual == test.Expected ? "PASS" : "FAIL")}");
        }
    }

    public static int HowManyUniquePathsTo(int n, int m)
    {
        if (n <= 0 || m <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Grid dimensions must be positive.");
        }

        int[,] paths = new int[n, m];

        for (int column = 0; column < m; column++)
        {
            paths[0, column] = 1;
        }

        for (int row = 0; row < n; row++)
        {
            paths[row, 0] = 1;
        }

        for (int row = 1; row < n; row++)
        {
            for (int column = 1; column < m; column++)
            {
                paths[row, column] = paths[row - 1, column] + paths[row, column - 1];
            }
        }

        return paths[n - 1, m - 1];
    }
}