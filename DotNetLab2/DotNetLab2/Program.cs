using System;
using DotNetLab2;


Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;


string? text = "Використання методів розширень";
Console.WriteLine($"Рядок: \"{text}\"");

//Інвертування рядка
string? inv_text;
inv_text = text.InverToString();
Console.WriteLine($"Інвертований рядок: \"{inv_text}\"");


//Підрахунок кількості входжень заданого у параметрі символа у рядок
char a = 'р';
int count = text.CharCount(a);
Console.WriteLine($"Кількість символів '{a}' в рядку: {count}\n");


string[] array = {"bool","int","string","int","int","char"};
Console.Write("Масив: ");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

//Визначення скільки разів повторюється задане значення в масиві
string value = "int";
int calc = array.ValueCount(value);
Console.WriteLine($"\nЗначення '{value}' повторюється {calc} разів");

//Видалення повторів масиву
string[] new_n = array.UnoqueArray();
Console.Write("Новий масив: ");
for(int i = 0; i < new_n.Length; i++)
    Console.Write($"{new_n[i]} ");




//Створення словника з ініціалізація першого елемента, та виведення в консоль
ExtendedDictionaryElement<string,string,string>[] dictionary = new ExtendedDictionaryElement<string, string, string>[1];
dictionary[0] = new ExtendedDictionaryElement<string, string, string>("cry", "кричати", "плакати");
ExtendedDictionaryElement<string, string, string>.PrintDictionary(dictionary);

//Додавання елементів в словник, та виведення в консоль
dictionary = ExtendedDictionaryElement<string,string,string>.AddElement(dictionary, "connect", "з'єднувати", "зв'язувати");
dictionary = ExtendedDictionaryElement<string, string, string>.AddElement(dictionary, "cat", "кошеня", "кіт");
ExtendedDictionaryElement<string, string, string>.PrintDictionary(dictionary);

//Видалення елемента за заданим ключем
dictionary = ExtendedDictionaryElement<string, string, string>.RemoveElement(dictionary, "connect");
ExtendedDictionaryElement<string, string, string>.PrintDictionary(dictionary);

//Перевірка наявності елемента із заданим ключем (якщо знайдено, то повертається індекс. Інакше -1).
//В разі успіху виводимо цей елемент в консоль
int indx = ExtendedDictionaryElement<string, string, string>.CheckByKey(dictionary, "cry");
Console.WriteLine($"\n\nІндекс знайденого елемента за ключем: {indx}");
if(indx>=0)
    ExtendedDictionaryElement<string, string, string>.PrintElement(dictionary[indx]);

//Перевірка наявності елемента із заданими значеннями 1 та 2 (якщо знайдено, то повертається індекс. Інакше -1).
//В разі успіху виводимо цей елемент в консоль
indx = ExtendedDictionaryElement<string, string, string>.CheckByValues(dictionary, "кошеня", "кіт");
Console.WriteLine($"\n\nІндекс знайденого елемента за значеннями: {indx}");
if (indx >= 0)
    ExtendedDictionaryElement<string, string, string>.PrintElement(dictionary[indx]);
