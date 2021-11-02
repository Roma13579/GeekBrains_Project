/*                                                      2 Урок "Базовые типыв С#"
*                                                Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №3
 *                                              Определить, является ли введённое пользователем число чётным.
 */
using System;

namespace DZ_GB_Lesson_2__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number: ");
            string n = Console.ReadLine();
            if (Convert.ToInt32(n) % 2 == 0)
                Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
