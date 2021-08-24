using System;
using System.Text;

namespace reverse_int
{
    public class Solution
    {
        public int Reverse(int x)
        {   
            // Edge cases:
            // X being 0 means you want to return 0

            // Since Abs(int.MinValue) will overflow due to it being int.MaxValue + 1,
            // we have to check for it.
            
            if (x == 0 || x == int.MinValue)
            {
                return 0;
            }

            StringBuilder builder = new();
            var absolute = Math.Abs(x);

            while (absolute > 0)
            {
                var tempNum = absolute % 10;
                builder.Append(tempNum);
                absolute = absolute / 10;
            }

            try
            {
                if (x < 0)
                {
                    return Int32.Parse(builder.ToString()) * -1;
                }
                else
                {
                    return Int32.Parse(builder.ToString());
                }
            }

            // Yeet overflows (╯°□°）╯︵ ┻━┻ (No this is not a good way to do it, 
            // better solution is to check for overflow in the loop like the submitted answers do)

            catch (OverflowException)
            {
            }

            return 0;
        }
    }
}