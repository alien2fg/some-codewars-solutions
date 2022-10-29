//1 version
using System;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if(a==null||b==null||a.Length!= b.Length) return false;
   for(int i=0;i<a.Length;i++)
   {
     a[i]=a[i]*a[i];
   }
    Array.Sort(a);
    Array.Sort(b);
    for(int i=0;i<a.Length;i++)
   {
     if(a[i]!=b[i]) return false;
   }
     return true;
  }
}
//2 version
/*using System;
using System.Linq;*/

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if ((a == null) || (b == null)){
      return false;
    }

    int[] copy = a.Select(x => x * x).ToArray();
    Array.Sort(copy);
    Array.Sort(b);

    return copy.SequenceEqual(b);
  }
}
//3 version
/*using System;
using System.Linq;*/
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
         return a == null || b==null ? false : a.Sum() == b.Sum(x => Math.Sqrt(x));
  }
}