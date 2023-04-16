using System;
using System.Linq;

public class Kata
{
    public static double SumArray(double[] array)
    {
        return (array.Length == 0) ? 0 : array.Sum();
    }
}
