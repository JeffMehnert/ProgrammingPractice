//Codewars link: http://www.codewars.com/kata/5526fc09a1bbd946250002dc

public class FindOutlier{
  	static int find(int[] integers){
  		int evenCount = 0;
  		int oddCount = 0;

  		for(int i = 0; i < 3; i++)
  		{
  			if(integers[i] % 2 != 0) oddCount++;
  			else evenCount++;
  		}
  		boolean isEvenArray = true;
  		if(oddCount > evenCount) isEvenArray = false;
  		
  		for(int i = 0; i < integers.length; i++)
  		{
  			if(isEvenArray) //if even array, search for an odd number
  			{
  				if(integers[i] % 2 != 0)
  				{
  					return integers[i];
  				}
  			}
  			else //if odd array, search for even number
  			{
  				if(integers[i] % 2 == 0)
  				{
  					return integers[i];
  				}
  			}
  		}
  		return 0;
	}
}