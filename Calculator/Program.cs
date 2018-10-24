using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string op = "";
            int result;

            Console.Write("Enter Your First Number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Operator: + - / * ");
            op = Console.ReadLine();

            Console.Write("Choose Your Second Number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = firstNum - secondNum;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = firstNum * secondNum;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = firstNum / secondNum;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
