public class Kata
{
    public static int[] BubbleSortOnce(int[] input)
    {
        int[] result = new int[input.Length];
        input.CopyTo(result, 0);
        int temp = 0;
        for (int i = 0; i < result.Length - 1; i++)
        {
            if (result[i] > result[i + 1])
            {
                temp = result[i + 1];
                result[i + 1] = result[i];
                result[i] = temp;
            }
        }
        return result;
    }
}