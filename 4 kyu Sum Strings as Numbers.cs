using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    { 
      if(a=="")a="0";
      if(b=="")b="0";
      BigInteger num1 = BigInteger.Parse(a);
      BigInteger num2 = BigInteger.Parse(b);
      return (num1+num2).ToString();
    }
}