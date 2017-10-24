//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdjacentNumber
{
    public class MaxDistance
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int[] arr = {0,3,3,7,5,3,11,1};
            
            Console.WriteLine("Hello, world! " + solution(arr));
        }
        
        public static int solution (int[] arr)
        {
          int result = 0;
          Console.WriteLine (Array.LastIndexOf(arr, 1));

          
          int [] tempArr = new int[arr.Length];
          
          Array.Copy(arr, tempArr, arr.Length);       
          Array.Sort(tempArr);
          

          
          for (int i=0; i < arr.Length - 1; i++)
          {
            int a = tempArr[i];
            int b = tempArr[i+1];
            
            
            
            if (a == b)
            {
              
            }
            else
            {
              int c = Array.IndexOf(arr,a);
                           
              int d = Array.LastIndexOf(arr, b);
                            
              int newResult = d - c;
              
              if (newResult > result)
              {
                result = newResult;                
              }
              
            }         
          }
          
          return result;
          
        }
        


    }
}
