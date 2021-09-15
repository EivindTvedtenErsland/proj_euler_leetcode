using System;

namespace buy_stock
{
     public class Solution
     {
          public int MaxProfit(int[] prices)
          {
               int currentMax = 0;
               int maxSoFar = 0;
     
               for (int i = 1; i < prices.Length; i++)
               {    
                    // Credit goes to earlme at leetcode forums
                    
                    // Look at difference between this step and the former step (i - 1), 
                    // and add/subtract it to the currentMax

                    // if currentMax falls below 0, reset it 

                    // At each loop check if currentMax is greater than maxSoFar

                    // If greater, store currentMax as maxSoFar
                    
                    // First example: {1,2,7,5,3,8}

                    //           +1   +5   -2   -2   +5
                    // currentMax:  1 -> 6 -> 4 -> 2 -> 7
                    // maxSoFar:    1 -> 6 -> 6 -> 6 -> 7
                    currentMax = Math.Max(0, currentMax += prices[i] - prices[i - 1]);
                    maxSoFar = Math.Max(maxSoFar, currentMax);
               }

               return maxSoFar;
          }
     }
}