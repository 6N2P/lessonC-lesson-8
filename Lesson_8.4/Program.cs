using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Lesson_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string street = string.Empty;
            int houseNumber = 0;
            int flatNumber = 0;
            int mobilePhone = 0;
            int flatPhone = 0;

            name = StringVar("Введите своё ФИО");
            street = StringVar("Введите улицу на которой проживаете");
            houseNumber = Number("Введите номер дома проживания");
            flatNumber = Number("Введите номер квартиры проживания");
            mobilePhone = Number("Введите свой номер телефона");
            flatPhone = Number("Введите свой номер домашнего телефона. Ели его нет то введите '1'");

            XElement xPerson = new XElement("Person");
            XElement xAddress = new XElement("Address");
            XElement xStreet = new XElement("Street",street);
            XElement xHouseNumber = new XElement("HouseNumber",houseNumber);
            XElement xFlatNumber = new XElement("FlatNumber",flatNumber);
            XElement xPhones = new XElement("Phoness");
            XElement xMobilePhone = new XElement("MobilePhone",mobilePhone);
            XElement xFlatPhone = new XElement("FlatPhone",flatPhone);

            XAttribute xAName = new XAttribute("name", name);

            xAddress.Add(xStreet, xHouseNumber, xFlatNumber);
            xPhones.Add(xMobilePhone, xFlatPhone);

            xPerson.Add(xAName, xAddress, xPhones);

            xPerson.Save("_Person.xml");




        }

        /// <summary>
        /// Метод проверяет корректное ли число
        /// </summary>
        /// <param name="question">Вопрос для пользователя</param>
        /// <returns>Возвращает число</returns>
        public static int Number (string question)
        {            
            string isNumber = string.Empty;
            int number = 0;

            while (true)
            {
                Console.WriteLine(question);
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
        /// Метод получает строку данных от пользователя
        /// </summary>
        /// <param name="question">Вопрос пользователю</param>
        /// <returns></returns>
        public static string StringVar(string question)
        {
            Console.WriteLine(question);
            string stringResult = Console.ReadLine();
            return stringResult;
        }

        
    }
}
