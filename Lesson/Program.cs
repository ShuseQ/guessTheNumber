using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int tries = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower} и меньше чем {higher}.");
            Console.WriteLine($"Что это за число? У вас {tries} попыток.");

            while (tries-- > 0)
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Правильный ответ, ответ: " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали. Попробуйте снова!");
                }
            }
            Console.WriteLine("Вы проиграли. Выбранное число: " + number);
        }
    }
}
