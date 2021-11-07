using System;

namespace DZ_GB_Lesson_3__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write line:   ");
            var line = int.Parse(Console.ReadLine());
            
            Console.Write("Write column:  ");
            int column = int.Parse(Console.ReadLine());
            var array = new int[line, column];

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Write number:  ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int padLeft = 0;
                foreach (var item in array)
                {
                    Console.WriteLine(item.ToString().PadLeft(padLeft += 1)); 
                }

        }
    }
}
