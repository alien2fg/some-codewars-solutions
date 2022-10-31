using System;
class GapInPrimes
{

    public static bool is_prime(long n)
    {
        for (long i = 2; i < n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static long[] Gap(int g, long m, long n)
    {
        int j = 0;
        long[] t = new long[n + 2 - m];
        long[] result = new long[2];
        for (long i = m; i <= n; i++)
        {
            if (is_prime(i))
            {
                t[j] = i;
                j++;
            }
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i + 1] - t[i] == Convert.ToInt64(g))
            {
                result[0] = t[i];
                result[1] = t[i + 1];
                return result;
            }
        }
        return null;
    }
}