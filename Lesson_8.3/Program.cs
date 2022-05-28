using System;
using System.Collections.Generic;

namespace Lesson_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hash = new HashSet<int>();
            hash = AddHash();
            ShowHash(hash);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод заполняет Hash
        /// </summary>
        /// <returns></returns>
        static HashSet<int> AddHash()
        {
            HashSet<int> hash = new HashSet<int>();
            while (true)
            {                
                int number = IsNumber();
                hash.Add(number);

                Console.WriteLine("Для выхода из режима ввода нажмите 'q'");
                string exit = Console.ReadLine();
                if (exit == "q")
                {
                    break;
                }
            }
            return hash;
        }

        /// <summary>
        /// Метод проверяет введённое число
        /// </summary>
        /// <returns>возвращает число</returns>
        public static int IsNumber()
        {
            string isNumber = string.Empty;
            int number = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                isNumber = Console.ReadLine();
                if (int.TryParse(isNumber, out number))
                {
                    number = Convert.ToInt32(isNumber);
                    break;
                }
                Console.WriteLine("Не корректное чило");
            }
            return number;
        }

        /// <summary>
        /// Метод отображает содержимое Hash
        /// </summary>
        /// <param name="hash"></param>
        public static void ShowHash(HashSet<int> hash)
        {
            Console.WriteLine("Содержимое Hash");
            foreach (int v in hash)
            {
                Console.WriteLine(v);
            }
        }
    }
}
