/*                                                  4 Урок "Методы. Стандарты классов в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №3
 *                       Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
 *                На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, принимающий на вход значение из этого перечисления и возвращающий
 *                           название времени года (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
 *                Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
 */
using System;

namespace DZ_GB_Lesson_4__3
{
    class Program
    {

        public enum Season
        {
            spring, //весна
            autumn, //осень
            summer, //лето
            winter, //зима
            noSeason
        }
        static Season month_Number(int month)
        {
            switch (month)
            {
                case 1: return Season.winter;
                case 2: return Season.winter;
                case 3: return Season.spring;
                case 4: return Season.spring;
                case 5: return Season.spring;
                case 6: return Season.summer;
                case 7: return Season.summer;
                case 8: return Season.summer;
                case 9: return Season.autumn;
                case 10: return Season.autumn;
                case 11: return Season.autumn;
                case 12: return Season.winter;
                default: return Season.noSeason;
            }

        }

        private static string GetNameSesons(Season str)
        {
            switch (str)
            {     
            case Season.winter: return Convert.ToString(Season.winter);
            case Season.spring: return Convert.ToString(Season.spring);
            case Season.summer: return Convert.ToString(Season.summer);
            case Season.autumn: return Convert.ToString(Season.autumn);
            default: return Convert.ToString(Season.noSeason);
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Write number month (1 - 12): ");
            string month = Console.ReadLine();
            int s = int.Parse(month);
            if (s > 12)
                Console.Write("Error");
            else
                Console.WriteLine(GetNameSesons(month_Number(s)));        
        }
    }
}
