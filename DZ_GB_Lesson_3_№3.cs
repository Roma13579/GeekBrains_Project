/*                                                       3 Урок "Массивы. Строки. Операторы цикла в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №3
 *                          Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
 */
using System;

namespace DZ_GB_Lesson_3__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write str: ");
            string s = Console.ReadLine();
            char[] array = s.ToCharArray();
            s = "";
            for (int i = array.Length-1; i >= 0 ; i--)
            {
                s += array[i];
            }
            Console.WriteLine();
            Console.WriteLine(s);
        }
    }
}
