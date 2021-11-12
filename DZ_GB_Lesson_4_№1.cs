/*                                                       4 Урок "Методы. Стандарты классов в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 *              Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
 *                                              Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

 */
using System;

namespace DZ_GB_Lesson_4__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetFullName(string firstName, string lastName, string patronymic)
            {
                if (firstName != null)
                {
                   
                    return firstName;
                }
                else if (lastName != null)
                {
                    return lastName;
                }
                else
                {   
                    return patronymic;
                }
            }
           
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Write your firstName: ");
                string firstNameExe = Console.ReadLine();
                Console.Write("Write your lastName : ");
                string lastNameExe = Console.ReadLine();
                Console.Write("Write your patronymic : ");
                string patronymicExe = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Result: {GetFullName(firstNameExe, null, null)}_{GetFullName(null, lastNameExe, null)}_{GetFullName(null, null, patronymicExe)}");
                Console.WriteLine();

            }
          

        }
    }
}
