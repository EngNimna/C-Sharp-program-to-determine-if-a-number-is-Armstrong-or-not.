using System;

namespace cSharpArmstrongOfNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number2, rem=0, ams=0;
            Console.Write("Enter the number...: ");
            number = int.Parse(Console.ReadLine());
            number2 = number;

            while (number > 0)
            {
                rem = number % 10;
                ams = ams + (rem * rem * rem);
                number = number / 10;
            }

            if (number2 == ams)
            {
                Console.WriteLine(number2 + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(number2 + " is not an Armstrong number.");
            }
        }
    }
}
