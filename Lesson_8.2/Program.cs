using System;
using System.Collections.Generic;

namespace Lesson_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dictionary<int, string> dictionaryPhones = new Dictionary<int, string>();

                while (true)
                {
                    WritePhoneNumber(dictionaryPhones);

                    Console.WriteLine("Для завершения заполнения книги нажмите Enter \nДля продолжения ввода ведите любой знак");
                    string continuation = Console.ReadLine();
                    if (continuation == "")
                    {
                        break;
                    }
                }
                ShowContacts(dictionaryPhones);
                Console.WriteLine("для выхода из программы нажмите 'q'");
                string exit = Console.ReadLine();
                if(exit == "q")
                {
                    break;
                }
            }
        }
        /// <summary>
        /// Метод добовляет контакт в телефонную книгу
        /// </summary>
        /// <param name="dictionary"></param>
        public static void WritePhoneNumber(Dictionary<int,string> dictionary)
        {
            string isNumber = string.Empty;
            string nume = string.Empty;
            int numberPhone = 0;

            numberPhone = IsNumber();

            Console.WriteLine("Введите имя контакта");
            nume = Console.ReadLine();

            dictionary.Add(numberPhone, nume);
             
        }
        /// <summary>
        /// Метод показывает кому принадлежит номер
        /// </summary>
        /// <param name="dictionary"></param>
        public static void ShowContacts(Dictionary<int,string> dictionary)
        {
            Console.WriteLine("Для поиска");
            int number = IsNumber();
            if (dictionary.ContainsKey(number))
            {
                Console.WriteLine($"Номер телефона {number} принадлежит {dictionary[number]}");
            }
            else
            {
                Console.WriteLine("Такого номер нет");
            }
        }
        /// <summary>
        /// Метод проверяет есть ли буквы в номере телефона.
        /// </summary>
        /// <returns>возвращает номер телефона</returns>
        public static int IsNumber ()
        {
            string isNumber = string.Empty;            
            int numberPhone = 0;

            while (true)
            {
                Console.WriteLine("Введите номер телефона");
                isNumber = Console.ReadLine();
                if (int.TryParse(isNumber, out numberPhone))
                {
                    numberPhone = Convert.ToInt32(isNumber);
                    break;
                }
                Console.WriteLine("В номере телефона есть буквы");
            }
            return numberPhone;
        }
    }
}
