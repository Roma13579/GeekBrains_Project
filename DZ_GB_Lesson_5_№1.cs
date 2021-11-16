/*                                                  5 Урок " Работа с файловой подсистемой. Сериализация в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 *
 *                                      Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */
using System;
using System.IO;
namespace DZ_GB_Lesson_5__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "DZ_5_1.txt";
            Console.Write("Write str: ");
            string str = Console.ReadLine();
            File.WriteAllText(filename, str);
        }
    }
}
