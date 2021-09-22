using System;

namespace max_subarray
{
     public class Solution {
          public int MaxSubArray(int[] nums) {
          
               int currMax = 0;
               int totMax = int.MinValue;

               for (int i = 0; i < nums.Length; i++)
               {
                    currMax  = Math.Max(nums[i], nums[i] + currMax);

                    if (currMax > totMax)
                    {
                         totMax = currMax;
                    }
               }

               return totMax;
          }
     }
}