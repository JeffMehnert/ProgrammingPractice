//Hackerrank link: https://www.hackerrank.com/challenges/2d-array
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Hourglass {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        Console.WriteLine(findLargestHourglass(arr));
    }


    static int findLargestHourglass(int[][] arr)
    {
    	int currSum = 0;
    	int largestSum = Int32.MinValue;
       	for(int i = 0; i < 4; i++)
    	{
    		for(int j = 0; j < 4; j++)
    		{
    			currSum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
    			if(currSum > largestSum) largestSum = currSum;
    		}
    	}
    	return largestSum;
    }
}
