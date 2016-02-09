//Codewars link: http://www.codewars.com/kata/563b74ddd19a3ad462000054

public class Kata
{
  public static string Stringy(int size)
  {
    	string ret = "";
    	for(int i = 0; i < size/2; i++)
    		ret += "10";

    	if(size % 2 == 1)
    		ret += "1";

    		return ret;
  }
}