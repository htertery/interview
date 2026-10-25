using System;
using System.Collections.Generic;

namespace Coding.DynamicProgramming;

public static class LongestPalindrom
{
    public static void RunTests()
    {
        var cases = new (string Input, int Expected)[]
        {
            ("bbbab", 4),
            ("cbbd", 2),
            ("agbdba", 5),
            ("abc", 1),
            ("a", 1),
            ("aaaa", 4),
            ("", 0)
        };

        foreach (var test in cases)
        {
            try
            {
                int actual = GetLengthOfLongestPalindrom(test.Input);
                Console.WriteLine(
                    $"\"{test.Input}\" => {actual}; expected {test.Expected}: " +
                    $"{(actual == test.Expected ? "PASS" : "FAIL")}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"\"{test.Input}\" => threw {exception.GetType().Name}; expected {test.Expected}: FAIL");
            }
        }
    }

    public static int GetLengthOfLongestPalindrom(string str)
    {
        int n = str.Length;

        // interval DP 
        int[,] dp = new int[n,n];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                dp[i,j] = i==j ? 1 : 0;
            }
        }
        
        for(int len = 2; len <= n; len++)
        {
            for(int i = 0; i <= n-len; i++)
            {
                int j = i + len - 1;
                if(str[i] == str[j])
                {
                    dp[i,j] =  dp[i+1,j-1] + 2;
                }
                else
                {
                    dp[i,j] = Math.Max(dp[i+1,j], dp[i, j-1]);
                }
            }
        }

        return dp[0,n-1];
    }
}