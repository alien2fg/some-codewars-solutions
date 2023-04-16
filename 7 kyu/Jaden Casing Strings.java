public class JadenCase {

  public String toJadenCase(String phrase) {
    if(phrase != null && !phrase.isEmpty()){
    String[] arr = phrase.split(" ");
    String outString = "";
    for(String s : arr){
      outString += capitalize(s) + " ";
    }

    return outString.substring(0, outString.length() - 1);
    }else
      {
      return null;
    }
  }

  public static String capitalize(String str) {
    return Character.toUpperCase(str.charAt(0)) + str.substring(1);
  }

}
