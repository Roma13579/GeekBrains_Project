/*                                                       2 Урок "Базовые типыв С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 *Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
 
 */

using System;

namespace DZ_GB_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write min temperature: ");
            string min = Console.ReadLine();
            Console.Write("Write max temperature: ");
            string max = Console.ReadLine();
            Console.WriteLine($"Average temperature: {(Convert.ToInt32(min) + Convert.ToInt32(max)) / 2}");
        }
    }
}
