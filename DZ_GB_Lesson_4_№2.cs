/*                                                  4 Урок "Методы. Стандарты классов в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №2
 *                          Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
 *                                               Ввести данные с клавиатуры и вывести результат на экран.
 */
using System;

namespace DZ_GB_Lesson_4__2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Enter a sequence of numbers separated by a space: ");
               string str = Console.ReadLine();
                int sum = 0;
                var masNumb = str.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (masNumb[i] != ' ')
                   sum += Convert.ToInt32(masNumb[i]) - 48;
                }
                Console.WriteLine("{0}", sum);
        }
    }
}
