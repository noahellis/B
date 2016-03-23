using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetB
{
    class Fibonacci
    {
        public double userInput;
        public double temporaryTotal;

       
        public void GetNumber()
        {
            Console.WriteLine("Please enter a number to Fibonacci");
            userInput = double.Parse(Console.ReadLine());
            DoFibonacci();
        }

        public void DoFibonacci()
        {
            List<double> fibonacci = new List<double>();
            fibonacci.Insert(0, userInput);
            fibonacci.Insert(1, userInput);
            Console.WriteLine(userInput);
            for (double tempTotal = 0; tempTotal < 50; tempTotal++)
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
