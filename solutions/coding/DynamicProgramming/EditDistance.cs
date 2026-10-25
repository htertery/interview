using System;
using System.Collections.Generic;

public static class EditDistance
{
    public static void RunTests()
    {
        var cases = new (string Source, string Target, int Expected)[]
        {
            ("", "", 0),
            ("", "abc", 3),
            ("abc", "", 3),
            ("same", "same", 0),
            ("a", "b", 1),
            ("kitten", "sitting", 3),
            ("horse", "ros", 3),
            ("intention", "execution", 5)
        };

        foreach (var test in cases)
        {
            try
            {
                int actual = MinOperations(test.Source, test.Target);
                Console.WriteLine(
                    $"\"{test.Source}\" -> \"{test.Target}\": {actual}; expected {test.Expected}: " +
                    $"{(actual == test.Expected ? "PASS" : "FAIL")}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"\"{test.Source}\" -> \"{test.Target}\": threw {exception.GetType().Name}; expected {test.Expected}: FAIL");
            }
        }
    }

    public static int MinOperations(string str1, string str2)
    {
        int n  = str1.Length;
        int m = str2.Length;


        int[,] comp = new int[n+1,m+1];
        for(int i = 0; i < n + 1; i++)
        {
            comp[i,0] = i;
        }

        for(int j = 0; j < m + 1; j++)
        {
            comp[0,j] = j;
        }

        for(int i = 0; i < n + 1; i++)
        {
            for(int j = 0; j < m + 1; j++)
            {
                if(str1[i] == str2[j])
                {
                    comp[i,j] = comp[i-1, j-1];
                }
                else
                {
                    comp[i,j] = 1 + Math.Min(comp[i-1,j], Math.Min(comp[i,j-1], comp[i-1, j-1]));
                }
            }
        }

        return comp[n+1,m+1];
       
    }
}