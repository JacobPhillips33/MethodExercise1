using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise1
{
    internal class Methods
    {
        public static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hi, {name}, what is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{color} is a great color! What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Who wouldn't love a {animal}? What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Would you believe me if I told you that one time I was wearing a {color} shirt when I met a {animal} named {name} " +
                              $"at a concert by {band}?");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1/ num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int BonusAdd(params int[] bonusAdd)
        {
            int totalAdd = 0;

            foreach(int num in bonusAdd)
            {
                totalAdd += num;
            }

            return totalAdd;
        }
    }        
}
