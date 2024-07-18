using System.Globalization;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Step1();
            Step2();
            Step3();
            Step4();
        }

        /// <summary>
        /// 이름을 입력받아, 반갑다고 출력하는 프로그램을 작성해주세요
        /// </summary>
        static void Step1()
        {
            Console.WriteLine("당신의 이름을 입력해주세요");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}님, 만나서 반갑습니다.");
        }

        /// <summary>
        /// 두 실수를 유저로부터 한줄씩 입력받아, 마지막 줄엔 둘의 합을 출력해보아요
        /// </summary>
        static void Step2()
        {
            Console.WriteLine("첫 번째 실수를 입력하여 주세요");
            string firstStr = Console.ReadLine();
            float firstNum = float.Parse(firstStr);

            Console.WriteLine("두 번째 실수를 입력하여 주세요");
            string secondStr = Console.ReadLine();
            float secondNum = float.Parse(secondStr);

            Console.WriteLine($"두 수의 합은 {firstNum + secondNum} 입니다.");
        }

        /// <summary>
        /// 두 정수를 유저로부터 입력 받고, 몫과 나머지를 출력해보자
        /// </summary>
        static void Step3()
        {
            Console.Write("나누셈을 진행할 첫 번째 수를 입력하여 주세요 : ");
            string firstNum = Console.ReadLine();

            Console.Write("두번째 나눌 수를 입력해주세요 : ");
            string secondNum = Console.ReadLine();

            int quotient = int.Parse(firstNum) / int.Parse(secondNum);
            int remainder = int.Parse(firstNum) % int.Parse(secondNum);

            Console.WriteLine($"{firstNum}와 {secondNum}의 나눗셈 결과, 몫은 {quotient} 나머지는 {remainder}");
        }

        /// <summary>
        /// 세 정수를 유저로부터 입력 받고, 앞 두개 숫자를 더하고 세번째 수는 곱하는 프로그램을 작성하되, 
        /// “첫째수 더하기 둘째수에 셋째수를 곱한 값은 X 입니다” 라고 나오는 프로그램 제작.
        /// </summary>
        static void Step4()
        {
            Console.Write("첫째 정수 입력 : ");
            string firstNum = Console.ReadLine();

            Console.Write("둘째 정수 입력 : ");
            string secondNum = Console.ReadLine();

            Console.Write("셋째 정수 입력 : ");
            string thirdNum = Console.ReadLine();

            float result = (float.Parse(firstNum) + float.Parse(secondNum)) * float.Parse(thirdNum);

            Console.WriteLine($"첫째수 더하기 둘째수에 셋째수를 곱한 값은 {result} 입니다.");

        }
    }
}
