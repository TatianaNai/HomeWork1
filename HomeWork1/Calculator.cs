using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Calculator
    {
        public static bool IsOperator(char sybmol)
        {
            if (sybmol == '+' || sybmol == '-' || sybmol == '/' || sybmol == '*' || sybmol == '%')
                return true;
            else return false;
        }

        public static void GetResult(double number1, double number2, char mathOperator)
        {
            double result;
            switch (mathOperator)
            {
                case '+':
                    result = Math.Round(number1 + number2, 2);
                    Console.WriteLine("Результат = " + result);
                    break;
                case '-':
                    result = Math.Round(number1 - number2, 2);
                    Console.WriteLine("Результат = " + result);
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        break;
                    }
                    else
                    {
                        result = Math.Round(number1 / number2, 2);
                        Console.WriteLine("Результат = " + result);
                        break;
                    }
                case '*':
                    result = Math.Round(number1 * number2, 2);
                    Console.WriteLine("Результат = " + result);
                    break;
                case '%':
                    if (number1 < 0 || number2 < 0)
                    {
                        Console.WriteLine("Введите положительное число");
                        break;
                    }
                    else
                    {
                        result = Math.Round(number1 * number2 / 100, 2);
                        Console.WriteLine("Результат = " + result);
                        break;
                    }
                case 's':
                    if (number1 < 0)
                    {
                        Console.WriteLine("Введите положительное число");
                        break;
                    }
                    else
                    {
                        result = Math.Round(Math.Sqrt(number1), 2);
                        Console.WriteLine("Результат = " + result);
                        break;
                    }
            }
        }
    }
}
