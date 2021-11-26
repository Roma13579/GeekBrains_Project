/*                                                  8 Урок "Основные сущности проекта .Net" 
 *                                              Романенко Рома группа GU_C#_1896 (25.10.2021) 
 *                                                              Задание №1
 *
 *                         Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения (application-scope).
 *                         Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках. 
 *                         При следующем запуске отобразить эти сведения. Задать приложению версию и описание.
 */
using System;
using System.IO;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace DZ_GB_Lesson_9__1
{
    class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var options = configuration.Get<MyOption>();
            string age = "";
            if (options.Age == 0)
            {
                age = "age";
            }
            if (options.Age == 1)
            {
                age = "years";
            }
            if (options.Age >= 2)
            {
                age = "year";
            }
            if (options.Age >= 5)
            {
                age = "year";
            }
            Console.WriteLine($"Hello {options.Name}. Your age is {options.Age} {age} and your profession is {options.Profession}. ");
            Console.WriteLine();
            Console.WriteLine("Want to change your data? (yes/no)");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "yes":
                        Console.WriteLine("Write your name:");
                        options.Name = Console.ReadLine();
                        Console.WriteLine();
                        File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));

                        try
                        {
                            Console.WriteLine("Write your age:");
                            var x = Console.ReadLine();
                            options.Age = int.Parse(x);
                            Console.WriteLine();
                            File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));
                        }
                        catch (System.FormatException)
                        {
                        }

                        Console.WriteLine("Write your profession:");
                        options.Profession = Console.ReadLine();
                        Console.WriteLine();
                        File.WriteAllText("appsettings.json", JsonSerializer.Serialize(options));

                        Console.WriteLine("Data changed successfully");
                        Console.WriteLine("Press Enter to close");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case "no":
                        Console.WriteLine("By. Press Enter to close");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case "":
                        Console.Write("Error: Empty. Write 'yes' or 'no'");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error: Empty. Write 'yes' or 'no'");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
