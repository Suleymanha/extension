using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extension
{
    static class Extension
    {
        
        public static bool  Contain(this string str,string letter)
        {
            int temp = 0;
            for (int i=0; i<str.Length;i++)
            {
                if (str[i] == letter[0])
                {
                    for( int n=i+1,m=1; n < letter.Length; n++, m++)
                    {
                        if (str[n].ToString().ToLower() == letter[m].ToString().ToLower())
                        {
                            temp++;
                        }
                    }
                }
            }
            if (temp == letter.Length - 1)
            {
                return true;
            }
            return false;

        }
    }
}
