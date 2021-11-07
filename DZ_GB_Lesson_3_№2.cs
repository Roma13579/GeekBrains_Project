/*                                                       3 Урок "Массивы. Строки. Операторы цикла в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №2
 *              Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов:
 *                              первый элемент хранит имя контакта, второй — номер телефона/e-mail.
 */
using System;

namespace DZ_GB_Lesson_3__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2]; 
          
            for (int i = 0; i < 5; i++)
            {
                    
                        Console.Write("Write email: ");
                        array[i, 0] = Console.ReadLine();
                Console.Write("Write number: ");
                array[i, 1] = Console.ReadLine();

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        
    }
}
