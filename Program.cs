using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Enter values in this format: <num1> <operator> <num2>");
                return;
            }
            

            decimal num1 = decimal.Parse(args[0]);
            char op = char.Parse(args[1]);
            decimal num2 = decimal.Parse(args[2]);

            //decimal result = 0;

            switch (op)
            {
                case '+':
                    displayNumber(add,num1,num2);
                    break;
                case '-':
                    displayNumber(sub, num1, num2);
                    break;
                case '*':
                    displayNumber(mul, num1, num2);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                     displayNumber(div, num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }
         
           // Console.WriteLine($"The Result of {num1} and {num2} is: " + result);
            Console.ReadLine();
        }
        public static void displayNumber(Func<decimal, decimal, decimal> someFunction, decimal num1, decimal num2)
        {
            Console.WriteLine($"This is Function 1. The result of operations {num1} and {num2} is {someFunction(num1, num2)}");
        }

        private static decimal add(decimal x, decimal y) => x+y;
        private static decimal sub(decimal x, decimal y) => x-y;
        private static decimal mul(decimal x, decimal y) => x*y;
        private static decimal div(decimal x, decimal y) => x/y;

    }
}

