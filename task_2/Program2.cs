using System;
using System.Collections.Generic;
using System.Linq;

namespace task_2
{
    internal class Program2
    {
        /// <summary>
        /// печать телефонной книги. даже не знаю что еще в отдельный метод вынести)
        /// </summary>
        /// <param name="dictionary"></param>
        private static void PrintDictionary(Dictionary<string,string> dictionary)
        {
            foreach (var abonent in dictionary)
            {
                Console.WriteLine($"{abonent.Key,15} - {abonent.Value,25}");
            }
        }
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();
            
            while (true)
            {
                Console.WriteLine("Введите номер телефона");
                string number = Console.ReadLine();
                if (number == "") break;

                Console.WriteLine("Введите ФИО абонента");
                string  name = Console.ReadLine();

                dictionary.Add(number, name);
            }

            PrintDictionary(dictionary);

            while (true)
            {
                Console.WriteLine("Введите номер телефона чтобы узнать имя владельца");
                string searchNamber = Console.ReadLine();
                if (searchNamber == "") break;

                if(dictionary.TryGetValue(searchNamber, out string value))
                //if (dictionary.ContainsKey(searchNamber))
                {
                    //Console.WriteLine(dictionary[searchNamber]);
                    Console.WriteLine($"{searchNamber} - {value}");
                }
                else
                {
                    Console.WriteLine("такого нет, попробуй еще..");
                }
            }
            Console.WriteLine("До скорого!");
            Console.ReadLine();
        }
    }
}
