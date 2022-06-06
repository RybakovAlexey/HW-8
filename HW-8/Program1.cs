using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_8
{
    internal class Program1
    {   /// <summary>
    /// печать листа в одну строку с разделителем в конце
    /// </summary>
    /// <param name="list"></param>
        private static void PrintList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            Console.WriteLine("****************************************************************************");
        }
        /// <summary>
        /// метод возвращает лист с заданным кол-вом элементов
        /// заполненых рандомно от 0 до maxValue
        /// </summary>
        /// <param name="counts"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private static List<int> CreateList(int counts, int maxValue)
        {
            List<int> list = new List<int>();
            Random ran = new Random();
            for (int i = 0; i < counts+1; i++)
            {
                list.Add(ran.Next(maxValue));
            }
            return list;
        }
        /// <summary>
        /// возвращает лист с элементами, значение которых подходит заданому промежутку
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private static List<int> DeleteElements(List<int> list, int minValue, int maxValue)
        {
            return list.Where(i => i > minValue && i < maxValue).ToList();
        }
        static void Main(string[] args)
        {
            List<int> ListInt = new List<int>();

            ListInt = CreateList(100, 100);
            PrintList(ListInt);

            ListInt = DeleteElements(ListInt, 25, 50);
            PrintList(ListInt);
        }
        
    }
}
