using System;
using System.Collections.Generic;
using System.Linq;

public static class MaxAvgSub
{
    public static void RunTests()
    {
        Console.WriteLine("[1, 12, -5, -6, 50, 3], k = 4");
        Console.WriteLine(GetMaxAvgSub([1, 12, -5, -6, 50, 3], 4));
    }

    public static double GetMaxAvgSub(int[] a, int k)
    {
        int left = 0;
        int right = k;
        double currentAvg = 0;

        if(a == null || a.Length == 0)
        {
            throw new ArgumentException("Array argument cannot be null or empty !");
        }

        if(k <= 0)
        {
            throw new ArgumentException("Invalid argument K");
        }

        if(k > a.Length)
        {
            throw new ArgumentException("K cannot be bigger than array length !");
        }

        double tempSum = 0;
        for(int i = 0; i<k;i++)
        {
            tempSum+=a[i];
        }
        currentAvg = tempSum/k;
        Dictionary<string,double> avgs = new Dictionary<string,double>();
        avgs.Add($"{left} - {right}",currentAvg);

        double tempAvgMax = currentAvg;

        while(right < a.Length)
        {
            
            tempSum -= a[left];
            tempSum += a[right++];
            left++;
            currentAvg = tempSum/k;

            avgs.Add($"{left} - {right}",currentAvg);

            if (currentAvg > tempAvgMax)
            {
                tempAvgMax = currentAvg;
            }
        }

        return tempAvgMax;
    }
}