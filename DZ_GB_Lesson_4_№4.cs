/*                                                  4 Урок "Методы. Стандарты классов в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №3
 *
 *                                  (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
 */
using System;

namespace DZ_GB_Lesson_4__4
{
    class Program
    {
        static long Fib(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Write Number: ");
            string a = Console.ReadLine();
            int number = int.Parse(a);
            Console.Write($"Fib: {Fib(number)}");

        }
    }
}
