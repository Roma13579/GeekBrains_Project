/*                                                       3 Урок "Массивы. Строки. Операторы цикла в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №4
 *                       *«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
 */
using System;

namespace DZ_GB_Lesson_3__4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[10, 10];
            void func_Write_X (int i, int j)
            {
                array[i, j] = "X";
            }
          
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 1; j++)
                {

                    Console.Write("Write i: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Write j: ");
                    int b = int.Parse(Console.ReadLine());
                    array[a, b] = "X";

                }
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (array[i, j] == "X")
                    {
                        func_Write_X(i, j);
                    }
                    else
                    {
                        Console.Write("O");
                    }

                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
