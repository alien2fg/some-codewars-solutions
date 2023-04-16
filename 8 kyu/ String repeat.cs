namespace Solution
{
    using System;
    using System.Linq;
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string text = "";
            for (int i = 0; i < n; i++)
            {
                text = text + s;
            }
            return text;
        }
    }
}
