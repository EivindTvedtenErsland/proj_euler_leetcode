using System;

namespace roman_to_int
{

    public class Solution
    {
        public int RomanToInt(string s)
        {
            // No idea if this holds for all edge cases but ¯\_(ツ)_/¯

            // Idea here is that if you traverse a roman number in reverse, 
            // you only have to check if the letter before is of significance
            // (e.g if current letter is 'I', was the former one 'V' or 'X')
            // If that's the case, you'll simply subtract the letter value from the sum

            int sum = 0;
            Char lastChar = 'A';

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == 'I')
                {
                    if (lastChar == 'V' || lastChar == 'X')
                    {
                        sum = sum - 1;
                        lastChar = 'I';
                    }
                    else
                    {
                       sum = sum + 1;
                       lastChar = 'I';  
                    }
            
                }
                if (s[i] == 'V')
                {
                   sum = sum + 5;
                   lastChar = 'V';
                }
                if (s[i] == 'X')
                {
                   if (lastChar == 'L' || lastChar == 'C')
                    {
                        sum = sum - 10;
                        lastChar = 'X';
                    }
                    else
                    {
                       sum = sum + 10;
                       lastChar = 'X';  
                    }
                }
                if (s[i] == 'L')
                {
                   sum = sum + 50;
                   lastChar = 'L'; 
                }
                if (s[i] == 'C')
                {
                  if (lastChar == 'D' || lastChar == 'M')
                    {
                        sum = sum - 100;
                        lastChar = 'C';
                    }
                    else
                    {
                       sum = sum + 100;
                       lastChar = 'C';  
                    }  
                }
                if (s[i] == 'D')
                {
                    lastChar = 'D'; 
                    sum = sum + 500;
                }
                if (s[i] == 'M')
                {   
                    lastChar = 'M'; 
                    sum = sum + 1000;
                }
            }

            return sum;
        }
    }
}