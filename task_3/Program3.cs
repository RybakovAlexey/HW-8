using System;
using System.Collections.Generic;
using System.Linq;

namespace task_3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            var hash = new HashSet<int>();

            while (true)
            {
                Console.WriteLine("Введите целое число для добавления в коллекцию или q для выхода");
                string str = Console.ReadLine();

                if (str == "q") break;

                int i = Int32.Parse(str);

                if (hash.Contains(i))
                {
                    Console.WriteLine($"{i} уже существует в коллекции");
                }
                else
                {
                    hash.Add(i);
                }
            }
            Console.WriteLine("А разговоров то было..");
            
        }
    }
}
