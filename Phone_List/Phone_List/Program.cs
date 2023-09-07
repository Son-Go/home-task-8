using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_List
{
    internal class Program
    {
        public static Dictionary<string, string> FindFone(Dictionary<string, string> dict)
        {

            return dict;
        }

        public static Dictionary<string, string> PhoneListAdd(Dictionary<string, string> dict)
        {
            string fio;
            string phoneNumber;

            Console.Write("Введите ФИО: ");
            fio = Console.ReadLine();

            Console.Write("Введите номер телефона: ");
            phoneNumber = Console.ReadLine();

            dict.Add(phoneNumber, fio);
            Console.WriteLine("Данные сохранены!!");

            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine("Что бы закончить ввод, введите пустую строку.");

            return dict;
        }

        public static void ProgramMenu()
        {
            bool flag = true;
            string choice, emptyString = "";

            Console.WriteLine("Введите 1, что бы ввести данные в телефонную книжку.");
            Console.WriteLine("Введите 2, что бы закрыть программу.");
            Console.WriteLine("Введите 3, что бы найти пользователя по номеру телефона.");

            while (flag)
            {
                Console.WriteLine("Введите команду: ");
                choice = Console.ReadLine();

                if (choice == emptyString)
                {
                    flag = false;
                    break;
                }

                switch (choice)
                {
                    case "1":
                        {
                            Dictionary<string, string> dict = new Dictionary<string, string>();

                            PhoneListAdd(dict);
                            break;
                        }
                    case "2":
                        {
                            flag = false;
                            Console.WriteLine("Закрытие программы....");
                            break;
                        }
                    case "3":
                        {
                            Dictionary<string, string> dict = new Dictionary<string, string>();

                            FindFone(dict);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неизвестная команда!! Введите 1 или 2");
                            break;
                        }
                }
            }
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> newDict = new Dictionary<int, string>();

            ProgramMenu();
        }
    }
}
