﻿using System;
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
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            if (age >= 18)
            {
                Console.WriteLine("Вы можете пройти!");
            }
            else
            {
                Console.WriteLine("Вы слишком юны, приходите через " + (18 - age) + " лет!");
            }
        }
    }
}
