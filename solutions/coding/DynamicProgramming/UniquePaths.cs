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
        int[,] paths = new int [n,m];

        for(int i = 0; i < n; i++)
        {
            paths[0,i] = 1;
        }
        for(int j = 0; j < m; j++)
        {
            paths[j,0] = 1;
        }

        for(int i = 1; i < n; i++)
        {
            for(int j = 1; j < m; j++)
            {
                paths[i,j] = paths[i-1,j]+paths[i,j-1];
            }
        }

        return paths[n-1,m] + paths[n,m-1];
    }
}