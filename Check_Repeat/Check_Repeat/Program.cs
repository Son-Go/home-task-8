using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cycleRepeatCount;
            HashSet<int> numbers = new HashSet<int>();

            Console.Write("Введите число повторений цикла: ");
            cycleRepeatCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycleRepeatCount; i++)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                    Console.WriteLine($"Число {number} успешно сохранено!");
                }
                else
                {
                    Console.WriteLine($"Число {number} уже вводилось ранее!!!");
                }
            }
        }
    }
}
