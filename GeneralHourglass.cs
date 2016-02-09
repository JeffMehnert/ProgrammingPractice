//Original question Hackerrank link: https://www.hackerrank.com/challenges/2d-array
//With this file, I decided to modify the challenge of the link provided on the line above, to accomodate for any dimension of a 2d array, not just 6x6.
//Also, this program tells you the index at which you can find the northwest-most coordinate of the largest hourglass.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class GeneralHourglass {
    static int xCoord = -1;
    static int yCoord = -1;


    static void Main(String[] args) {
        Console.WriteLine("Enter the dimension of your array: ");
        int dimension = Convert.ToInt32(Console.ReadLine());
        if (dimension >= 3)
        {
            Console.WriteLine("Generated array:");
            int[,] arr = generateArray(dimension);
            Console.WriteLine();
            Console.WriteLine("Sum of largest hourglass: {0}", findLargestHourglass(arr));
            Console.Write("Coordinate of largest hourglass: ");
            Console.Write("({0}, {1})", yCoord, xCoord);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Dimension must be at least 3");
            Console.ReadKey();
        }
    }


    static int findLargestHourglass(int[,] arr)
    {
        int currSum = 0;
        int largestSum = Int32.MinValue;
        int dimension = arr.GetLength(0);
        for(int i = 0; i < dimension-2; i++)
        {
            for(int j = 0; j < dimension-2; j++)
            {
                currSum = arr[i,j] + arr[i,j+1] + arr[i,j+2] + arr[i+1,j+1] + arr[i+2,j] + arr[i+2,j+1] + arr[i+2,j+2];
                if (currSum > largestSum)
                {
                    largestSum = currSum;
                    xCoord = i;
                    yCoord = j;
                }
            }
        }
        return largestSum;
    }

    static int[,] generateArray(int dim)
    {
        Random rand = new Random();
        int[,] foobar = new int[dim, dim];
        for(int i = 0; i < dim; i++)
        {
            for(int j = 0; j < dim; j++)
            {
                foobar[i, j] = rand.Next(-9, 10);
                Console.Write("{0}\t", foobar[i,j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        return foobar;
    }
}