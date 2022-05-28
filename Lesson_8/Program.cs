using System;
using System.Collections.Generic;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lisiInt = new List<int>();
            FillingListRandomNumbers(lisiInt);
            PrintList(lisiInt);
            lisiInt = DeleteNumbersSpecifiedRange(lisiInt);
            Console.WriteLine("\n \n");
            
            PrintList(lisiInt);
            Console.ReadKey();
        }
        /// <summary>
        /// Заполняет лист случайными числами
        /// </summary>
        /// <param name="list"></param>
        public static List<int>  FillingListRandomNumbers (List<int> list)
        {            
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 100));
            }
            return list;
        }
        /// <summary>
        /// Выводит лист на экран
        /// </summary>
        /// <param name="list">Список</param>
        public static void PrintList(List<int> list)
        {
            foreach (int v in list)
            {
                Console.Write($"{v}, ");
            }
        }

        public static List<int> DeleteNumbersSpecifiedRange(List<int> list)
        {
            List<int> listNew = new List<int>();
            foreach(int v in list)
            {
                if (v < 25 || v>50)
                {
                    listNew.Add(v);
                }
            }
            return listNew;
        }
    }
}
