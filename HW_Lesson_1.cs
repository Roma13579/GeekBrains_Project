/*                                                       1 Урок "Введение в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 * 
 *      Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
 *  Имя пользователя сохранить из консоли в промежуточную переменную. Поставить точку останова и посмотреть значение этой переменной в режиме отладки. 
 *      Запустить исполняемый файл через системный терминал.
*/
using System;

namespace Dz_1_Lesson_1
{
    class Program_1
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            string user_Name = Console.ReadLine();
            Console.WriteLine($"Hello, {user_Name}, today {DateTime.Now}");
        }
    }
}