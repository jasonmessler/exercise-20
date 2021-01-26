using System;

namespace exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {

                Console.Write("Enter a number ");
                var input = Console.ReadLine();
                var userInput = int.Parse(input);

                Console.WriteLine($"The product of { userInput}, { userInput - 1}, and {userInput - 2} is  {(userInput) * (userInput - 1) * (userInput - 2)}");

                Console.WriteLine("would you like to continue (y/n) ");
                answer = Console.ReadLine();

            } while (answer == "y");

            Console.WriteLine("Goodbye!");
            Console.ReadLine();


        }
    }
}
