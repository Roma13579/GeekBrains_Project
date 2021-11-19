/*                                                  6 Урок " Обработка ошибок. Работа с процессами в С#" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 *
 *                           Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
 *                                     Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
 *                           В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
 */

using System;
using System.Diagnostics;
using System.Linq;
namespace DZ_GB_Lesson_6__1
{
    class Program
    {
        public static void WriteProcess()
        {
            Console.Write("Write 1 , to terminate the process by Name, or Write 2 , to terminate the process by ID: ");
            

        }

        static void Main(string[] args)
        {
            var processes = Process.GetProcesses();
            foreach (var processe in processes)
            {
                Console.WriteLine($"{nameof(Process.ProcessName)}: {processe.ProcessName}, {nameof(Process.Id)}: {processe.Id}");
            }
            WriteProcess();
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Write Process Name: ");
                        var name = Console.ReadLine();
                        try
                        {
                            foreach (var processe in Process.GetProcessesByName(name))
                            {
                                processe.Kill();
                            }
                            Console.WriteLine($"Process {name} is deleat.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Process {name} not found."); // обработка исключений по не правельно введенному названия процесса
                            Console.WriteLine();
                            WriteProcess();
                            Console.WriteLine();
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine($"Process not found!"); 
                            Console.WriteLine();
                            WriteProcess();
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.Write("Write Process ID : ");
                        Console.WriteLine();
                        var namecase2 = Console.ReadLine();
                        try
                        {
                            var y = int.Parse(namecase2); 
                            var x = Process.GetProcessById(y);
                            x.Kill();
                            Console.WriteLine($"ID: {x} delete.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"ID {namecase2} not exist."); 
                            Console.WriteLine();
                            WriteProcess();
                            Console.WriteLine();
                        }
                        catch (System.ArgumentException)
                        {
                            Console.WriteLine($"ID {namecase2} not exist."); 
                            Console.WriteLine();
                            WriteProcess();
                            Console.WriteLine();
                        }
                        break;

                    case "":
                        Console.Write("Error. Empty field. Write 1 or 2.");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error: Write on 1 or 2 .");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
