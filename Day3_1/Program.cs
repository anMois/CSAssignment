namespace Day3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 심화 과제
            int checkNum;
            int.TryParse(Console.ReadLine(), out checkNum);

            #region if문
            if (checkNum == 1)
            {
                Console.WriteLine("Cocked Pistol");
            }
            else if (checkNum == 2)
            {
                Console.WriteLine("Fast Pace");
            }
            else if (checkNum == 3)
            {
                Console.WriteLine("Round House");
            }
            else
            {
                Console.WriteLine("비상 대세");
            }
            #endregion

            #region switch문
            switch (checkNum)
            {
                case 1:
                    Console.WriteLine("Cocked Pistol");
                    break;
                case 2:
                    Console.WriteLine("Fast Pace");
                    break;
                case 3:
                    Console.WriteLine("Round House");
                    break;
                default:
                    Console.WriteLine("비상 대세");
                    break;
            }
            #endregion
            #endregion


            Console.Write("성공한 갯수를 입려하여 주세요(최대 갯수는 100까지입니다.) ");
            int score;
            bool isScore = int.TryParse(Console.ReadLine(), out score);

            if (isScore)
            {
                if (score >= 100)
                {
                    Console.WriteLine("SS 등급입니다.");
                }
                else if (score >= 90)
                {
                    Console.WriteLine("S 등급입니다.");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("A 등급입니다.");
                }
                else if (score >= 40)
                {
                    Console.WriteLine("B 등급입니다.");
                }
                else
                {
                    Console.WriteLine("F 등급입니다.");
                }
            }
            else
            {
                Console.WriteLine("점수가 아닌 다른 것을 기입하였습니다.");
            }
        }
    }
}
