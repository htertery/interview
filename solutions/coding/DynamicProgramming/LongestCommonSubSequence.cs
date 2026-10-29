using System;

using System.Collections.Generic;
using System.Text;

public static class LongestCommonSub
{
    public static void RunTests()
    {
        var cases = new (string First, string Second, int Expected)[]
        {
            ("abcde", "ace", 3),
            ("abc", "abc", 3),
            ("abc", "def", 0),
            ("AGGTAB", "GXTXAYB", 4),
            ("", "abc", 0),
            ("abc", "", 0),
            ("a", "a", 1),
            ("a", "b", 0)
        };

        foreach (var test in cases)
        {
            try
            {
                int actual = GetLongestCommonSub(test.First, test.Second);
                Console.WriteLine(
                    $"{test.First} / {test.Second} => {actual}; expected {test.Expected}: " +
                    $"{(actual == test.Expected ? "PASS" : "FAIL")}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"{test.First} / {test.Second} => threw {exception.GetType().Name}; expected {test.Expected}: FAIL");
            }
        }
    }

    public static int GetLongestCommonSub(string str1, string str2)
    {
        int[,] comp = new int[str1.Length + 1, str2.Length + 1];

        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    comp[i, j] = comp[i - 1, j - 1] + 1;
                }
                else
                {
                    comp[i, j] = Math.Max(comp[i - 1, j], comp[i, j - 1]);
                }
            }
        }

        return comp[str1.Length, str2.Length];
    }
}