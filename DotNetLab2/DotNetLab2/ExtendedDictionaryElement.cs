using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab2
{
    public class ExtendedDictionaryElement<T, U, V>
    {
        public T Key { get; set; }
        public U First_value { get; set; }
        public V Second_value { get; set; }
        public static int CountElements { get; set; }

        public ExtendedDictionaryElement(T key, U first_value, V second_value)
        {
            Key = key;
            First_value = first_value;
            Second_value = second_value;

            CountElements += 1;
        }

        public static ExtendedDictionaryElement<T, U, V>[] AddElement(ExtendedDictionaryElement<string, string, string>[] array, T key, U first_value, V second_value)
        {
            ExtendedDictionaryElement<T, U, V>[] new_array = new ExtendedDictionaryElement<T, U, V>[array.Length + 1];
            Array.Copy(array, new_array, array.Length);
            new_array[array.Length] = new ExtendedDictionaryElement<T, U, V>(key, first_value, second_value);
            return new_array;
        }

        public static ExtendedDictionaryElement<T, U, V>[] RemoveElement(ExtendedDictionaryElement<string, string, string>[] array, T key)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i].Key.ToString() == key.ToString())
                    index = i;
            ExtendedDictionaryElement<T, U, V>[] array_new = new ExtendedDictionaryElement<T, U, V>[array.Length - 1];
            if (index >= 0)
            {
                Array.Copy(array, 0, array_new, 0, index);
                Array.Copy(array, index + 1, array_new, index, array.Length - index - 1);
                CountElements--;
            }
            return array_new;
        }

        public static int CheckByKey(ExtendedDictionaryElement<string, string, string>[] array, T key)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i].Key.ToString() == key.ToString())
                    index = i;
            return index;
        }
        public static int CheckByValues(ExtendedDictionaryElement<string, string, string>[] array, U first_value, V second_value)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i].First_value.ToString() == first_value.ToString() && array[i].Second_value.ToString() == second_value.ToString())
                    index = i;

            return index;
        }

        public static void PrintDictionary(ExtendedDictionaryElement<string, string, string>[] array)
        {
            Console.WriteLine("\n\nРозширений словник:");
            foreach(var elem in array)
            {
                Console.WriteLine($"Ключ: {elem.Key}\t Значення: {elem.First_value}\t Значення: {elem.Second_value}\t");
            }
            Console.WriteLine($"Кількість записів: {CountElements}");
        }

        public static void PrintElement(ExtendedDictionaryElement<string, string, string> elem)
        {
            Console.WriteLine("Елемент:");         
            Console.WriteLine($"Ключ: {elem.Key}\t Значення: {elem.First_value}\t Значення: {elem.Second_value}\t");
        }

    }
}
