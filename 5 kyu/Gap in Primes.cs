using System;
class GapInPrimes
{

    public static bool is_prime(long n)
    {
        if (n == 2) return true;

        if (n <= 1 || n % 2 == 0) return false;
        int max = (int)Math.Floor(Math.Sqrt(n));
        for (long i = 3; i <= max; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static long[] Gap(int g, long m, long n)
    {
        long last_prime = -1, current = m;

        while (current <= n)
        {
            if (is_prime(current))
            {
                if (last_prime == -1)
                {
                    last_prime = current;
                }
                else
                {
                    if (current - last_prime == g) return new long[] { last_prime, current };
                    else
                        last_prime = current;
                }
            }
            ++current;
        }
        return null;
    }
}
