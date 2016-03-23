using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetB
{
    class Fibonacci
    {
        public int userInput;
        public int temporaryTotal;

       
        public void GetNumber()
        {
            Console.WriteLine("Please enter a number to Fibonacci");
            userInput = int.Parse(Console.ReadLine());
            DoFibonacci();
        }

        public void DoFibonacci()
        {
            List<int> fibonacci = new List<int>();
            fibonacci.Insert(0, userInput);
            fibonacci.Insert(1, userInput);
            Console.WriteLine(userInput);
            for (int tempTotal = 0; tempTotal < 20; tempTotal++)
            {
                fibonacci.Add(temporaryTotal = (fibonacci[0] + fibonacci[1]));
                Console.WriteLine(temporaryTotal + ", ");
                fibonacci.RemoveAt(0);
            }
            RestartFibonacci();
        }

        public void RestartFibonacci()
        {
            Console.WriteLine("Would you like to try another number?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "yes":
                    GetNumber();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
