using System;
using System.Collections.Generic;
using System.Linq;

namespace longest_substr_no_repeat
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            // Credit goes to chrisTris on leetcode forums for this one
            // My shitty code couldn't handle all cases and looked like shit

            Dictionary<char, int> letters = new Dictionary<char, int>();
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (letters.TryGetValue(s[i], out int index))
                {
                    length = Math.Max(length, letters.Count);
                    i = index;
                    letters.Clear();
                }
                else
                {
                    letters.Add(s[i], i);
                }
            }
            length = Math.Max(length, letters.Count);
            return length;
        }
    }
}

// Archiving this garbage code 

/*
      public int LengthOfLongestSubstring(string s)
        {

            HashSet<char> countLetters = new();
            Dictionary<string, int> substrLength = new();
            string temp = "";

            for (int i = 0; i < s.Length;)
            {
                if (!countLetters.Contains(s[i]))
                {
                    countLetters.Add(s[i]);
                    temp = temp + s[i];
                    i++;
                }
                else
                {
                    if (!substrLength.ContainsKey(temp))
                    {
                        substrLength.Add(temp, temp.Length);
                    }
                    countLetters.Clear();
                    temp = s[i].ToString();
                   
                }
            }

            try
            {
                if (substrLength.Values.Max() >= temp.Length)
                {
                    return substrLength.Values.Max();
                }
                else
                {
                    return temp.Length;
                }

            }
            catch
            {
                return temp.Length;
            }
        }
*/