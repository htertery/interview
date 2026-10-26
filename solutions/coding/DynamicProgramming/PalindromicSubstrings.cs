using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.DynamicProgramming;

public static class PalindromicSubstring
{
    public static void RunTests()
    {
        var cases = new (string Input, int Expected)[]
        {
            ("abc", 3),
            ("aaa", 6),
            ("abba", 6),
            ("aba", 4),
            ("racecar", 10),
            ("", 0),
            ("a", 1)
        };

        foreach (var test in cases)
        {
            try
            {
                int actual = GetCountOfPalindromicSubstrings(test.Input);
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

    public static int GetCountOfPalindromicSubstrings(string str)
    {
        Dictionary<string, bool> cache = new Dictionary<string, bool>();
        
        int count = 0;
        for(int i = 0; i < str.Length; i++)
        {
            for(int j = i; j < str.Length; j++)
            {
                if (IsPalindrom(i,j,str,cache)){
                    count++;
                };
            }
        }
        
        return count;
    }

    public static bool IsPalindrom(int i, int j, string str, Dictionary<string,bool> cache)
    {
        if (cache.ContainsKey($"i-{i}-j-{j}"))
        {
            return cache[$"i-{i}-j-{j}"];
        }

        bool result = false;

        if (i >= j)
        {
            result = true;
        } 
        else if(str[i] != str[j])
        {
          result = false;  
        }
        else
        {
            result = IsPalindrom(i+1,j-1, str, cache);
        }
        
        cache.Add($"i-{i}-j-{j}",result);

        return result;
    }
}