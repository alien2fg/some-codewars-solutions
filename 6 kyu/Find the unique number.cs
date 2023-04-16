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

//older version
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    int fElm=numbers.First();
    int j=0;
    foreach(int i in numbers){
        if(i!=fElm){
          switch(j){
              case 1:
                  if(fElm==numbers.ElementAt(2)){
                    return i;
                  }
                   else{
                     return fElm;
                  }
                  break;
              default:
                  if(fElm==numbers.ElementAt(j-1)){
                    return i;
                  }
                  else{
                    return fElm;
                  }
          }
        }
      j++;
    }
    return 0;
  }
}
