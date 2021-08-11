namespace valid_pal_onlyalph
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            s = s.Trim();
            int i = 0;
            int j = s.Length - 1;

            if (s.Length == 1)
            {
                return true;
            }

            //Credit goes to amandeep18feb from leetcode forums for this one, quite the genius solution. 
            //Example: (aabbcaa) -> (abbca) -> (bbc) -> (bb || bc) -> (bc != cb -> false) || (bb == bb -> true), true || false -> true 
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return ValidPalindrome(s, i + 1, j) || ValidPalindrome(s, i, j - 1);
                }
                i++;
                j--;
            }
            return true;
        }

        private static bool ValidPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--])
                    return false;
            }
            return true;
        }
    }
}