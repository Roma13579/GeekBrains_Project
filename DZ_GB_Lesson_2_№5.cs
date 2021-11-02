/*                                                       2 Урок "Базовые типыв С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №5
 *                      (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
 */

using System;

namespace DZ_GB_Lesson_2__5
{
    class Program
    {
        enum month
        { 
            January,
            February,
            December,
        }
        static void Main(string[] args)
        {
            Console.Write("Write min temperature: ");
            string min = Console.ReadLine();
            Console.Write("Write max temperature: ");
            string max = Console.ReadLine();
            Console.Write("Write month: ");
            string n = Console.ReadLine();
            var inputMonth = Enum.Parse<month>(n);

            if (((inputMonth == month.January) || (inputMonth == month.December) || (inputMonth == month.February)) && (((Convert.ToInt32(min) + Convert.ToInt32(max)) / 2 > 0)))
            {
                Console.WriteLine("rainy weather");
            }
            else Console.WriteLine("incorrect input");
        }
    }
}
