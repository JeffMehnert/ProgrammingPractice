//Codewars link: http://www.codewars.com/kata/55d8dc4c8e629e55dc000068

public class Trigrams {
	public static String trigrams(String phrase)
	{
		if(phrase.length() < 3) return "";
		String trigram = "";
		String sub = "";
		for(int i = 0; i < phrase.length()-2; i++)
		{
			sub = phrase.substring(i,i+3);
			if(sub.contains(" "))
				sub = sub.replaceAll(" ", "_");
			if(i == phrase.length()-3)
				trigram += sub;
			else
				trigram += sub + " ";
		}
		return trigram;
	}
}