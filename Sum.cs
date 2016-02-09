  using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       if(a == b) return a;
       int sum = 0;
       if(a > b)
       {
        for(int i = b; i <= a; i++)
        {
          sum += i;
        }
       }
        else if(a < b)
        {
          for(int i = a; i <= b; i++)
          {
          sum += i;
          }
        }
       
       return sum;
     }
  }