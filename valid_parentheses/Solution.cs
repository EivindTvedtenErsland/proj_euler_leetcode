using System.Collections.Generic;

namespace valid_parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            bool check = true;
            Dictionary<char, int> map = new();
            Dictionary<char, char> closeBrackets = new()
            {
                {'}', '{'},
                {')', '('},
                {']', '['}
            };
            for (int i = 0; i < s.Length; i++)
            {
                map.TryAdd(s[i], i);

                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    // TODO: getValueOrDefault will return 0 if no opposite bracket is found in map
                    // Have to find a way to check for that, else cases such as "[}" will fail the test
                     
                    var indx = map.GetValueOrDefault(closeBrackets.GetValueOrDefault(s[i]));
                    if (indx + 1 == i)
                    {
                        s = s.Remove(indx,2);
                        i = 0;
                    }
                    else
                    {
                        check = IsValid(s.Substring(indx, i - 1));
                        map.Clear();
                    }
                }
            }

            if (s.Length == 1)
            {
                check = false;
            }

            return check;
        }
    }
}