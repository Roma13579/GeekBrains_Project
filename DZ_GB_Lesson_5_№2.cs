/*                                                  5 Урок " Работа с файловой подсистемой. Сериализация в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №2
 *
 *                             Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */
using System;
using System.IO;
namespace DZ_GB_Lesson_5__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            string data = Convert.ToString(DateTime.Now);
            File.WriteAllText(filename, data);

        }
    }
}
