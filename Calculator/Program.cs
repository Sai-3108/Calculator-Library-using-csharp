using System;
using CalculatorLibrary;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string? restart_calculator = "no";
            string[] operator_Array = new string[4] { "+", "-", "*", "/" };
            double number1;
            double number2;
            do
            {
                Console.WriteLine("   MILESTONE CALCULATOR    ");
                Console.WriteLine("[ + ] --> Addition");
                Console.WriteLine("[ - ] --> Substraction");
                Console.WriteLine("[ * ] --> Multiplication");
                Console.WriteLine("[ / ] --> Division");
                Console.WriteLine("Choose Your Operation :");
                string? oprtr = Console.ReadLine();

                while (!operator_Array.Contains(oprtr))
                {
                    Console.WriteLine("  Wrong Input" + "\n " + " Available operations are  + , - , * , / ");
                    Console.WriteLine("Choose Your Operation :");
                    oprtr = Console.ReadLine();
                }
                Console.WriteLine("Enter The First Number :");
                string? input = Console.ReadLine();

                while (Double.TryParse(input, out double n) == false)
                {
                    Console.WriteLine("Enter Actual Number");
                    input = Console.ReadLine();
                    input = Console.ReadLine();
                }
                number1 = Double.Parse(input);
                Console.WriteLine("Enter The Second Number :");
                string? input2 = Console.ReadLine();
                while (Double.TryParse(input2, out double n) == false)
                {
                    Console.WriteLine("Enter Actual Number");
                    input2 = Console.ReadLine();
                }
                number2 = Double.Parse(input2);

                if (oprtr == "+")
                {
                    Console.WriteLine("The Answer is :" + Class1.Addition(number1, number2));
                    Console.WriteLine("Write 'yes'  to continue ");
                    restart_calculator = Console.ReadLine();
                }
                else if (oprtr == "-")
                {
                    Console.WriteLine("The Answer is :" + Class1.Substraction(number1, number2));
                    Console.WriteLine("Write 'yes'  to continue ");
                    restart_calculator = Console.ReadLine();
                }
                else if (oprtr == "*")
                {
                    Console.WriteLine("The Answer is :" + Class1.Multiplication(number1, number2));
                    Console.WriteLine("Write 'yes'  to continue ");
                    restart_calculator = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The Answer is :" + Class1.Division(number1, number2));
                    Console.WriteLine("Write 'yes'  to continue ");
                    restart_calculator = Console.ReadLine();
                }
            }
            while (restart_calculator == "yes" || restart_calculator == "y");
            if (restart_calculator != "yes")
            {

                Console.WriteLine(" See you Again !! Bye Bye ");

            }
        }
    }
}
