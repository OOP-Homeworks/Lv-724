using System;
using System.Collections.Generic;
using System.Text;

namespace Sytnyk_Illia_s_Homework_9
{
    public static class StringExtension
    {
        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}
