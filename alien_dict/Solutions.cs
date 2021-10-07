using System;
using System.Collections.Generic;

namespace alien_dict
{
     public class Solution
     {
        public bool IsAlienSorted(string[] words, string order)
        {
            // Intent here was to distill the words array into a wordDict, where letter and position
            // were stored in a Key/Value pair for quick lookup when comparing to the orderDict. 
            // So currently the wordDict is unused.
            Dictionary<char, int> orderDict = new Dictionary<char, int>();
            Dictionary<char, int> wordDict = new Dictionary<char, int>();

            bool check = true;
            string temp, temp_2;

            // Store character/position in a dict. This means that character with lower 
            //  Value have higher priority for the sake of comparison.
            for (int i = 0; i < order.Length; i++)
            {
                orderDict.TryAdd(order[i], i);
            }

            // This is a rather naive approach. Iterate through the string[] words,
            // and compare each word with it's predecessor. Exit loop if any of the 
            // comparisons are false (e.g that that words[j - 1] should be in front of words[j])
            for (int j = 1; j < words.Length; j++)
            {
                temp = words[j - 1];
                temp_2 = words[j];

                // int minLength = temp.Length > temp_2.Length ? temp_2.Length: temp.Length;
                int minLength = Math.Min(temp.Length, temp_2.Length);
                int maxLength = Math.Max(temp.Length, temp_2.Length);

                // Iterate through the characters of both words, and check if they are similar or not
                for (int k = 0; k < minLength; k++)
                {
                    // If the characters are not similar, we have two situations:
                    // 1: We look at the orderdict which stores the character/position of the order string.
                    // If the value of the orderDict[temp[k]] is greater than orderDict[temp_2[k]],
                    // this would imply that the words are out of order (0 is highest priority here)
                    // 2: If the words are in correct order, break out to outer loop to continue checking
                    // the remaining words
                    if (temp[k] != temp_2[k])
                    {
                        if (orderDict[temp[k]] > orderDict[temp_2[k]])
                        {
                            return false;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // This is in case of ["app", "apple"] edge cases, where we don't find
                    // distinction between the characters and reach the end of the minLength. 
                    // In this case we have to compare the length of the two strings
                    // temp.Length should be more than temp_2.Length
                    // E.g ["app", "apple"] is valid, ["apple", "app"] is not.
                    else if (k == minLength - 1)
                    {
                        if (temp.Length > temp_2.Length)
                        {
                            return false;
                        }
                    }
                }
            }
            return check;
        }
    }
}