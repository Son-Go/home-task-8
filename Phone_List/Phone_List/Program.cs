using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_List
{
    internal class Program
    {

        static Dictionary<string, string> _myDict = new Dictionary<string, string>();

        public static Dictionary<string, string> FindFone(Dictionary<string, string> dict)
        {
            dict = _myDict;

            Console.Write("Номер телефона: ");
            string searchNumber = Console.ReadLine();

            string owner;

            if (_myDict.TryGetValue(searchNumber, out owner))
            {
                Console.WriteLine($"Владелец номера телефона {searchNumber}: {owner}");

                return _myDict;
            }
            else
            {
                Console.WriteLine($"Владелец номера телефона {searchNumber} не найден.");

                return null;
            }
        }

        public static Dictionary<string, string> PhoneListAdd(Dictionary<string, string> dict)
        {
            string fio;
            string phoneNumber;
            bool flag = true;
            string choice, emptyString = "";

            while (flag)
            {
                Console.Write("Введите ФИО: ");
                fio = Console.ReadLine();

                Console.Write("Введите номер телефона: ");
                phoneNumber = Console.ReadLine();

                if (phoneNumber.Length == 11)
                {
                    dict.Add(phoneNumber, fio);
                    Console.WriteLine("Данные сохранены!!");
                }
                else
                {
                    Console.WriteLine("Длина номера телефона должна быть равна 11");
                }

                foreach (var item in dict)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }

                Console.WriteLine("Что бы закончить ввод, введите пустую строку.");

                choice = Console.ReadLine();

                if (choice == emptyString)
                {
                    flag = false;
                    break;
                }
            }

            return dict;
        }

        public static void ProgramMenu()
        {
            bool flag = true;
            string choice;

            Console.WriteLine("Введите 1, что бы ввести данные в телефонную книжку.");
            Console.WriteLine("Введите 2, что бы закрыть программу.");
            Console.WriteLine("Введите 3, что бы найти пользователя по номеру телефона.");

            while (flag)
            {
                Console.WriteLine("Введите команду: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            PhoneListAdd(_myDict);
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
                            FindFone(_myDict);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неизвестная команда!! Введите 1, 2 или 3");
                            break;
                        }
                }
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();

            ProgramMenu();
        }
    }
}
