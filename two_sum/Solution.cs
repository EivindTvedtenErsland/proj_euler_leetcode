using System.Collections.Generic;
using System.Linq;

namespace two_sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] temp = { 0, 0 };
            Dictionary<int, int> ValLookup = new Dictionary<int, int>();

            for (int j = 0; j < nums.Length; j++)
            {
                //Set target value to find in dict
                int complement = target - nums[j];

                //If the value is in the dict, then return a int array with the indexes of the values, j because you know that the value found in nums[j] is part of the solution
                //ValLookup[complement] since we know that ValLookup[complement] will give us the second index as a value
                if (ValLookup.ContainsKey(complement))
                {
                    temp[0] = j;
                    temp[1] = ValLookup[complement];
                    return temp;
                }
                //Added this part after looking at others solutions since populating a dict at start fails for duplicate nums values (C# dicts require unique keys)
                //This is a notable performance loss, and leads to runtimes similar to just brute forcing, but ¯\_(ツ)_/¯
                else if (!ValLookup.ContainsValue(complement)){

                    //Add a dict which contains keyvaluepairs which are reversed compared to the nums array (example: nums[0] = 13, ValLookup[13] = 0)
                    ValLookup.Add(nums[j], j);
                }
            }
            return temp;
        }
    }
}