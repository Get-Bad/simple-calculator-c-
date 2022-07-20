namespace Calculator
{
    public static class Calculator
    {
        private static void Main(string[] args)
        {
            int sum1;
            int sum2;
            String mathOperator;

            Console.WriteLine("Enter first number: ");
            sum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter math operator: ");
            mathOperator = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            sum2 = Convert.ToInt32(Console.ReadLine());

            switch(mathOperator)
            {
                case "+":
                    int sumAnswer = sum1 + sum2;
                    Console.WriteLine("Answer: " + sumAnswer);
                    break;
                
                case "-":
                    sumAnswer = sum1 - sum2;
                    Console.WriteLine("Answer: " + sumAnswer);
                    break;

                case "*":
                    sumAnswer = sum1 * sum2;
                    Console.WriteLine("Answer: " + sumAnswer);
                    break;

                case "/":
                    sumAnswer = sum1 / sum2;
                    Console.WriteLine("Answer: " + sumAnswer);
                    break;

                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }
    }
}