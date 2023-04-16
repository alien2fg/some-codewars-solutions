using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    IEnumerable<int> sortnumbers=numbers.OrderBy(x => x);
    if(sortnumbers.First()!=sortnumbers.ElementAt(1)){
      return sortnumbers.ElementAt(0);
    }
    else{
      if(sortnumbers.First()!=sortnumbers.Last()){
      return sortnumbers.Last();
    }
      else{
        return 0;
    }
  }
}
}
