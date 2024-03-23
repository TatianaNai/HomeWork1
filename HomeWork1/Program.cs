
namespace HomeWork1
{
    class Program
    {
        public const int sqrtLength = 4;

        public static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            string stringNumber1;
            string stringNumber2;

            bool isNumber1 = false;
            bool isNumber2 = false;
            char mathOperator = default;

            do
            {
                Console.WriteLine("Введите выражение");
                string mathExpression = Console.ReadLine();

                if (mathExpression.Contains("sqrt"))
                {
                    stringNumber1 = mathExpression.Substring(sqrtLength, mathExpression.Length - sqrtLength);
                    isNumber1 = Double.TryParse(stringNumber1, out number1);
                    isNumber2 = true;
                    mathOperator = 's';
                }
                else
                {
                    for (int i = 1; i < mathExpression.Length - 1; i++)
                    {
                        if (Calculator.IsOperator(mathExpression[i]))
                        {
                            mathOperator = mathExpression[i];

                            stringNumber1 = mathExpression.Substring(0, i);
                            stringNumber2 = mathExpression.Substring(i + 1, mathExpression.Length - (i + 1));

                            isNumber1 = Double.TryParse(stringNumber1, out number1);
                            isNumber2 = Double.TryParse(stringNumber2, out number2);
                            break;
                        }
                    }
                }
            }
            while (!isNumber1 || !isNumber2);

            Calculator.GetResult(number1, number2, mathOperator);
        }
    }
}
