using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Методи розширення для класу string

namespace DotNetLab2
{
    public static class StringExtensions
    {
        //Інвертування рядка
        public static string? InverToString(this string? str)
        {
            string? strNew = null;

            if (str != null)
                for (int i = str.Length - 1; i >= 0; i--)
                    strNew += str[i];
            return strNew;
        }

        //Підрахунок кількості входжень заданого у параметрі символа у рядок
        public static int CharCount(this string? str, char ch)
        {
            int count = 0;
            if (str != null)
                for (int i = 0; i < str.Length; i++)
                    if (ch == str[i])
                        count++;        
            return count;
        }
    }
}
