using System;
using System.Collections.Generic;

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
            List<int> sortedInts = new List<int>();

            for (int index = 0; index < ints.Count; index++)
            {
                if (ints[index] >= 25 & ints[index] <= 50)
                {
                    ints.RemoveAt(index);

                    index--;
                }
            }
            return ints;
        }

        public static void PrintToConsole(List<int> ints)
        {
            Console.WriteLine($"Исходный список: {{ {String.Join(" ", ints)} }}");
        }


        /// <summary>
        /// Точка входа программы.
        /// </summary>
        /// <param name="args">Аргументы.</param>
        static void Main(string[] args)
        {   
            List<int> ints = GenerateNewList(); // Создание нового списка.

            PrintToConsole(ints);
            Console.WriteLine();

            List<int> newInts = DeleteNumbersFromList(ints);

            PrintToConsole(newInts); // Вывод списка с удалёнными числами.

            Console.ReadLine();
        }
    }
}
