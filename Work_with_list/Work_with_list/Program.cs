using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_list
{
    internal class Program
    {
        /// <summary>
        /// Метод создающий новый список.
        /// </summary>
        /// <param name="count">Число, указывающее максимальное число диапазона</param>
        /// <returns></returns>
        public static List<int> GenerateNewList()
        {
            Random randomNumber = new Random();

            List<int> ints = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                ints.Add(randomNumber.Next(0, 100));
            }

            return ints;
        }

        /// <summary>
        /// Метод, удаляющий элементы из списка, которые подоходят под условие.
        /// </summary>
        /// <param name="ints">Исходный список</param>
        /// <returns></returns>
        public static List<int> DeleteNumbersFromList(List<int> ints) 
        {
            for (int index = 0; 25 < index && index < 50; index++)
            {
                ints.Remove(index);
            }
                
            return ints;
        }


        /// <summary>
        /// Точка входа программы.
        /// </summary>
        /// <param name="args">Аргументы.</param>
        static void Main(string[] args)
        {   
            List<int> ints = GenerateNewList(); // Создание нового списка.

            Console.WriteLine($"Исходный список: {{ {String.Join(" ", ints)} }}"); // Вывод списка в консоль.
            Console.WriteLine();

            List<int> newInts = DeleteNumbersFromList(ints);

            Console.WriteLine($"Новый список: {{ {String.Join(" ", newInts)} }}"); // Вывод списка с удалёнными числами.

            Console.ReadLine();
        }
    }
}
