// Codewars link: http://www.codewars.com/kata/take-a-ten-minute-walk/java

  public static boolean isValid(char[] walk) {
	  if(walk.length != 10) return false;
	  int n = 0, s = 0, e = 0, w = 0;
	  for(char ch: walk)
	  {
		  switch(ch){
		  case 'n': n++;
		  break;
		  case 's': s++;
		  break;
		  case 'e': e++;
		  break;
		  case 'w': w++;
		  break;
		  }
	  }
	  if(w == e && n == s) return true;
	  else return false;
  }
}