using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubstring
{
    public class Program
    {
        public static int IsSubstringThere(string one, string two)
        {
            if (string.IsNullOrEmpty(one) || string.IsNullOrEmpty(two))
            {
                return -1;
            }
            string longer = string.Empty;
            string shorter = string.Empty;

            if (one.Length > two.Length)
            {
                longer = one.Trim().ToLower();
                shorter = two.Trim().ToLower();
            }
            else
            {
                longer = two.Trim().ToLower();
                shorter = one.Trim().ToLower();
            }

            for (int i = 0; i < longer.Length; i++)
            {
                if (longer[i] == shorter[0])
                {
                    for (int j = 0; j < shorter.Length; j++)
                    {
                        if (longer[i + j] == shorter[j] && j == shorter.Length)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
