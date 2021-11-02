/*                                                       2 Урок "Базовые типы в C#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №2
 *
 *                          Запросить у пользователя порядковый номер текущего месяца и вывести его название.
 */
using System;

namespace DZ_GB_Lesson_2__2
{
    class Program
    {
        [Flags]
        enum month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        static void Main(string[] args)
        {
            Console.Write("Write number month: ");
            string number = Console.ReadLine();
            switch (number)
            {      
                case "1":
                    Console.WriteLine(month.January);
                    break;   
                case "2":
                    Console.WriteLine(month.February);
                    break;
                case "3":
                    Console.WriteLine(month.March);
                    break;
                case "4":
                    Console.WriteLine(month.April);
                    break;
                case "5":
                    Console.WriteLine(month.May);
                    break;
                case "6":
                    Console.WriteLine(month.June);
                    break;
                case "7":
                    Console.WriteLine(month.July);
                    break;
                case "8":
                    Console.WriteLine(month.August);
                    break;
                case "9":
                    Console.WriteLine(month.September);
                    break;
                case "10":
                    Console.WriteLine(month.October);
                    break;
                case "11":
                    Console.WriteLine(month.November);
                    break;
                case "12":
                    Console.WriteLine(month.December);
                    break;
            }
        }
    }
}
