using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Write_Book
{
    internal class Program
    {

        public static void AddWorkerToXMLFile()
        {
            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();

            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();

            Console.Write("Введите номер дома: ");
            string houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры: ");
            string flatNumber = Console.ReadLine();

            Console.Write("Введите мобильный телефон: ");
            string mobilePhone = Console.ReadLine();

            Console.Write("Введите домашний телефон: ");
            string homePhone = Console.ReadLine();

            XElement xml = new XElement("Person",
               new XAttribute("name", name),
               new XElement("Address",
               new XElement("Street", street),
               new XElement("HouseNumber", houseNumber),
               new XElement("FlatNumber", flatNumber)
           ),
               new XElement("Phones",
               new XElement("MobilePhone", mobilePhone),
               new XElement("HomePhone", homePhone)
           )
       );

            xml.Save("contacts.xml");
        }

        static void Main(string[] args)
        {
            AddWorkerToXMLFile();
        }
    }
}
