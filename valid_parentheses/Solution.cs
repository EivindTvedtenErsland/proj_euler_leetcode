using System.Collections.Generic;

namespace valid_parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            // So ye this code runs, but in term of space- and time-complexity it performs in the bottom 5% 
            // TODO: Refractor, improve and retry
            
            bool check = true;
            Dictionary<char, int> map = new();
            Dictionary<char, char> closeBrackets = new()
            {
                { '}', '{' },
                { ')', '(' },
                { ']', '[' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if(!map.TryAdd(s[i], i))
                {
                    map[s[i]] = i;
                }

                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    char temp = s[i];
                    char value;
                    closeBrackets.TryGetValue(temp, out value);

                    if (map.ContainsKey(value))
                    {
                        var indx = map.GetValueOrDefault(value);
                        if (indx + 1 == i)
                        {
                            s = s.Remove(indx, 2);
                            i = -1;
                            map.Clear();
                            
                        }
                        else
                        {
                            check = IsValid(s.Substring(indx, i - 1));
                            map.Clear();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (s.Length > 0)
            {
                check = false;
            }

            return check;
        }
    }
}