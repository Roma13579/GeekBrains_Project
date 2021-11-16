using System.IO;
using System;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
namespace DZ_GB_Lesson_5__3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("bites.bin", FileMode.OpenOrCreate),bytes);
            }
    }
}
