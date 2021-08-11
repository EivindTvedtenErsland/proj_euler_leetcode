using System.Text.RegularExpressions;

namespace valid_pal_onlyalph
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.Trim();
            bool check = true;

            //Remove special characters, whitespace and set string to lower
            //Not very time- or memory-efficient, but regexes are neat
            //Probably more efficient to loop and check each char if a-z, A-Z, 0-9 -> create substr

            s = Regex.Replace(s, @"[^0-9a-zA-Z]+", "");
            s = s.Replace(" ", string.Empty);
            s = s.ToLower();

            int j = s.Length - 1;
            for (int i = 0; i < s.Length - 1; i++)
            {

                if (s[i] != s[j])
                {
                    check = false;
                    break;
                }

                j--;
            }

            return check;
        }
    }
}