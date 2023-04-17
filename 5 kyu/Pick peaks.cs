using System;
using System.Collections.Generic;
public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
         var posList = new List<int>();
        var peakList = new List<int>();

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                int j = i;
                int l = 0;
                while (j < arr.Length - 1 && arr[j] == arr[j + 1])
                {
                    j++;
                    l++;
                }

                if (j + 1 < arr.Length && arr[j] > arr[i - 1] && arr[j] > arr[j + 1])
                {
                    if (arr[j] == arr[j - 1])
                    {
                        posList.Add(j - l);
                        peakList.Add(arr[j - l]);
                    }
                    else
                    {
                        posList.Add(j);
                        peakList.Add(arr[j]);
                    }
                }

                i = j;
            }
        }

        return new Dictionary<string, List<int>> { { "pos", posList }, { "peaks", peakList } };
  
    }
}
