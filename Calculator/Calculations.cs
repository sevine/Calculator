using System;

namespace Calculator
{
    class Calculations
    {
        static void Main(string[] args)
        {
            var result = 0;
            var flagForClosingApp = false;

            Console.WriteLine("Hello! Here you can calculate 2 numbers using operations: \n+ \t- \t* \t/ \n");

            do
            {
                Console.Write("Type first argument and press Enter: ");
                var firstArgument = Convert.ToInt32(Console.ReadLine());

                Console.Write("Type opearation(+ - * /) and press Enter: ");
                var operation = Console.ReadLine();

                Console.Write("Type second argument and press Enter: ");
                var secondArgument = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        result = Plus.SummOfTwoIntegers(firstArgument, secondArgument);
                        break;
                    case "-":
                        result = Minus.SubtractOfTwoIntegers(firstArgument, secondArgument);
                        break;
                    case "*":
                        result = Multiply.MultiplyOfTwoIntegers(firstArgument, secondArgument);
                        break;
                    case "/":
                        result = Divide.DivideOfTwoIntegers(firstArgument, secondArgument);
                        break;

                    default:
                        Console.WriteLine("You type wrong operation");
                        break;
                }

                Console.WriteLine($"\nResult of calculation ({firstArgument} {operation} {secondArgument}) is equal to: {result}");

                Console.Write("\nFor a new calculation please type 'y', for close app - 'n' and press Enter: ");
                var userAnswer = Console.ReadLine();
                

                flagForClosingApp = userAnswer == "y" ? true : false;

                if (flagForClosingApp)
                    Console.Clear();

            } while (flagForClosingApp);
        }
    }
}
