using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorLibrary
{
     public class Class1
    {
        public static double Addition(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 + number2;
            return answer;
        }
        public static double Substraction(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 - number2;
            return answer;
        }
        public static double Multiplication(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 * number2;
            return answer;
        }
        public static double Division(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 / number2;
            return answer;

        }
    }
}
