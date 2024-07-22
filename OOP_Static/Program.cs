namespace OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 개의 수를 입려하세요.");
            Console.Write("첫 번째 : ");
            double.TryParse(Console.ReadLine(), out double firstNum);
            Console.Write("두 번째 : ");
            double.TryParse(Console.ReadLine(), out double secondNum);

            Console.WriteLine("해당 두 수로 무엇을 할것입니까? ");
            Console.WriteLine("1. 덧셈 | 2. 뺄셈 | 3. 곱셈 | 4. 나눗셈 | 5. 제곱");
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine($"{MyCalculator.Add(firstNum, secondNum)}");
                    break;
                case "2":
                    Console.WriteLine($"{MyCalculator.Subtract(firstNum, secondNum)}");
                    break;
                case "3":
                    Console.WriteLine($"{MyCalculator.Multiply(firstNum, secondNum)}");
                    break;
                case "4":
                    Console.WriteLine($"{MyCalculator.Divide(firstNum, secondNum)}");
                    break;
                case "5":
                    Console.WriteLine($"{MyCalculator.Squared(firstNum, secondNum)}");
                    break;
            }
        }
    }

    public static class MyCalculator
    {
        public static double Add(double _input1, double _input2)
        {
            return _input1 + _input2;
        }
        public static double Subtract(double _input1, double _input2)
        {
            return _input1 - _input2;
        }
        public static double Multiply(double _input1, double _input2)
        {
            return _input1 * _input2;
        }
        public static double Divide(double _input1, double _input2)
        {
            if (_input2 == 0)
            {
                Console.WriteLine("0으로 나눌수 없습니다.");
                //throw new Exception("0으로 나눌수 없습니다.");
                return 0;
            }
            else
                return _input1 / _input2;

        }
        public static double Squared(double _input1, double _input2)
        {
            double result = 1;
            for (int i = 0; i < _input2; i++)
            {
                result *= _input1;
            }
            return result;
        }
    }
}
