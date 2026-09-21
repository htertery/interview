using System;
using System.Collections.Generic;

namespace Coding.SlidingWindow;

public class LongestSubstringUniqueChars
{
    public static void RunTests()
    {
        var cases = new[]
        {
            new { Input = "abcabcbb", Expected = "abc" },
            new { Input = "bbbbb", Expected = "b" },
            new { Input = "pwwkew", Expected = "wke" },
            new { Input = "abcdef", Expected = "abcdef" },
            new { Input = "abba", Expected = "ab" }, // or "ba" depending on exact rule if ties allowed
            new { Input = "a", Expected = "a" },
            new { Input = "dvdf", Expected = "vdf" },
            new { Input = "", Expected = "" }, // depending on whether empty string is allowed
            new { Input = "abca", Expected = "abc" },
            new { Input = "tmmzuxt", Expected = "mzuxt" }
        };

        foreach (var test in cases)
        {
            var result = new string(GetLongestSubstringUniqueCharsV2(test.Input));
            Console.WriteLine($"{test.Input} => {result} | expected {test.Expected} | {(result == test.Expected ? "PASS" : "FAIL")}");
        }
    }

    public static char[] GetLongestSubstringUniqueCharsV2(string s)
    {
         Dictionary<char, int> seen = new Dictionary<char, int>();
        int bestStart = 0;
        int bestLength = 0;
        int left = 0;
        int windowLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (seen.ContainsKey(s[right]))
            {
                left = Math.Max(left, seen[s[right]] + 1);
            }

            seen[s[right]] = right;

            windowLength = right - left + 1;
            if (windowLength > bestLength)
            {
                bestLength = windowLength;
                bestStart = left;
            }
        }

           

            return s.Substring(bestStart,bestLength).ToCharArray(); 
    }

    public static char[] GetLongestSubstringUniqueChars(string givenString)
    {
        //"abcabcdab" -> 4 (abcd)
        // [a,b,a,c,c,d,k]

        if (string.IsNullOrWhiteSpace(givenString))
        {
            return Array.Empty<char>();
        }

        Dictionary<char, int> charSet = new Dictionary<char, int>();
        int maxLength = 0;
        int currentWindowStart = 0;
        int bestWindowStart = 0;

        int currentWindowEnd = 0;
        int bestWindowEnd = 0;


        for(int i = 0; i<givenString.Length; i++)
        {
            currentWindowEnd = i;

            if(charSet.ContainsKey(givenString[i]))
            {
                currentWindowStart = Math.Max(charSet[givenString[i]],currentWindowStart) + 1;
            }else{
                charSet.Add(givenString[i],i);
            }

            if((currentWindowEnd - currentWindowStart +1)> maxLength)
            {
                maxLength = (currentWindowEnd - currentWindowStart) + 1;
                bestWindowStart  = currentWindowStart;
                bestWindowEnd = currentWindowEnd;
            }
        }

        char[] result = new char[maxLength];
        int k = 0;
        for(int j = bestWindowStart; j<=bestWindowEnd; j++)
        {
            result[k] = givenString[j];
            k++;
        }

        return result;

    }
}