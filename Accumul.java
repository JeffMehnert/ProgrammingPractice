public class Accumul {
    
    public static String accum(String s) {
        String retString = "";
        for(int i = 0; i < s.length(); i++)
        {
            char currChar = s.charAt(i);
            char upperChar = Character.toUpperCase(currChar);
            char lowerChar = Character.toLowerCase(currChar);
            retString += upperChar;
            if(i < 0)
            {
                for(int j = 0; j < i; j++)
                {
                    retString += lowerChar;
                }
            }

            if(i != s.length()-1)
            {
                retString += "-";
            }


        }
     return retString;
    }
}