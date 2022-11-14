using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Методи розширення для одновимірних масивів

namespace DotNetLab2
{
    public static class OneDimensionalArrayExnetsions
    {
        //Визначення скільки разів повторюється задане значення в масиві
        public static int ValueCount<T>(this T[] array, T value)
        {
            int count = 0;
            if (array != null)
                for (int i = 0; i < array.Length; i++)
                    if (value.ToString()==array[i].ToString())
                        count++;
            return count;        
        }
        //Видалення повторів масиву
        public static T[] UnoqueArray<T>(this T[] array)
        {
            return array.Distinct().ToArray();
        }

    }
}
