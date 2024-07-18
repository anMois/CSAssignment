using System;
using System.Diagnostics;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제 1. 입력받은 횟수만큼 반복하는 기능 제작
            //int countNum;
            //bool numCheck;
            //
            //do
            //{
            //    Console.Write("몇회 반복하시겠습니까? : ");
            //    numCheck = int.TryParse(Console.ReadLine(), out countNum);
            //} while (numCheck == false || countNum < 0);
            //
            //for (int i = 0; i < countNum; i++)
            //{
            //    Console.WriteLine($"{i + 1}회 반복중입니다.");
            //}
            #endregion

            #region 과제 2. 다수의 입력을 받아 횟수만큼 반복하는 기능 제작
            //int smallNum;
            //int bigNum;
            //int result = 0;
            //
            //Console.WriteLine("두 수 사이의 합을 수합니다. 시작할 작은 수를 입력하여주세요");
            //int.TryParse(Console.ReadLine(), out smallNum);
            //
            //Console.WriteLine("끝 수를 입력해주세요");
            //int.TryParse(Console.ReadLine(), out bigNum);
            //
            //for (int i = smallNum; i <= bigNum; i++)
            //{
            //    result += i;
            //}
            //
            //Console.WriteLine($"{smallNum} 과(와) {bigNum} 사이의 합은 {result} 입니다.");
            #endregion

            #region 과제 3. 구구단 기능 제작
            //int num;
            //bool isNum;
            //
            //do
            //{
            //    Console.WriteLine("출력하고자 하는 구구단을 입력해주시길 바랍니다. (1 ~ 9 사이)");
            //    isNum = int.TryParse(Console.ReadLine(), out num);
            //} while (isNum == false || num < 1 || num > 9);
            //
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"{num} X {i} = {num * i}");
            //}
            #endregion

            #region 과제 4. 별찍기 기능 구현
            //int startNum;
            //
            //Console.WriteLine("1 ~ 4 중 하나만 선택하시오");
            //int.TryParse(Console.ReadLine(), out startNum);
            //
            //switch (startNum)
            //{
            //    case 1:
            //        for (int i = 0; i < 5; i++)
            //        {
            //            for (int j = 0; j < i + 1; j++)
            //            {
            //                Console.Write("*");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    case 2:
            //        for (int i = 0; i < 5; i++)
            //        {
            //            for (int k = 4; k > i; k--)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int j = 0; j < i + 1; j++)
            //            {
            //                Console.Write("*");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    case 3:
            //        for (int i = 0; i < 5; i++)
            //        {
            //            for (int j = 5; j > i; j--)
            //            {
            //                Console.Write("*");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    case 4:
            //        for (int i = 0; i < 5; i++)
            //        {
            //            for (int k = 0; k < i; k++)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int j = 5; j > i; j--)
            //            {
            //                Console.Write("*");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 입력을 하셨습니다.");
            //        break;
            //}
            #endregion

            #region 심화 과제
            UpgradeTest();
            #endregion
        }

        static void UpgradeTest()
        {
            #region 심화 과제 1. 조건에 따른 무한 반복 기능
            //int potalNum;
            //bool isPotalNum;
            //
            //PotalList();
            //do
            //{
            //    Console.WriteLine("이동 할 장소를 설정해주세요");
            //    isPotalNum = int.TryParse(Console.ReadLine(), out potalNum);
            //} while (isPotalNum == false || (potalNum != 1 && potalNum != 2 && potalNum != 3));
            //
            //Console.Clear();
            //switch (potalNum)
            //{
            //    case 1:
            //        Console.WriteLine("마을로 이동되었습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("사냥터로 이동되었습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("상점로 이동되었습니다.");
            //        break;
            //}
            #endregion

            #region 심화 과제 2. 입력을 통한 다이아몬드 출력 기능
            int diamondNum;
            bool isDiamondNumCheck;

            while (true)
            {
                Console.Write("출력할 다이아몬드를 홀수로 입력 : ");
                isDiamondNumCheck = int.TryParse(Console.ReadLine(), out diamondNum);

                //숫자가 아닌 다른것이 입력된 상태
                if (isDiamondNumCheck == false)
                {
                    Console.WriteLine("숫자가 아닌 다른것이 입력되었습니다.");
                }
                //숫자가 입력된 상태
                //1. 숫자가 1인가
                else if (diamondNum == 1)
                {
                    Console.WriteLine("1이 아닌값을 입력하시오");
                }
                //2. 짝수인가 홀수인가
                else if (diamondNum % 2 == 0)
                {
                    Console.WriteLine("짝수를 입력하였습니다.");
                }
                //3. 양수인가 음수인가
                else if (diamondNum < 0)
                {
                    Console.WriteLine("입력하신 숫자는 음수입니다.");
                }
                else
                    break;
            }

            int halfDiamond = diamondNum / 2;

            //다이아 조립
            //윗부분
            for (int i = 0; i <= diamondNum; i++)
            {
                //홀수인 숫자만 별을 만들기위한 조건문
                if (i % 2 == 1)
                {
                    for (int j = 0; j < halfDiamond; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    halfDiamond -= 1;
                }
            }
            //밑부분
            for (int i = diamondNum - 1; i >= 0; i--)
            {
                //홀수인 숫자만 별을 만들기위한 조건문
                if (i % 2 == 1)
                {
                    halfDiamond += 1;
                    for (int j = 0; j <= halfDiamond; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }

        static void PotalList()
        {
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. 상점");
        }

        //과제 2번을 예외처리를 하여 작성해봤습니다.
        //작성하다 보니 예외처리를 한 과제도 있고 안한 과제도 있는데
        //예외처리를 해두는 것이 좋을까요? 아니면 나중에 차근차근 배우면서 하는것이 좋을까요?
        static void Set2()
        {
            int smallNum;
            int bigNum;
            int result = 0;

            bool isSmallNumCheck;
            bool isBigNumCheck;

            do
            {
                Console.WriteLine("두 수 사이의 합을 수합니다. 시작할 작은 수를 입력하여주세요");
                isSmallNumCheck = int.TryParse(Console.ReadLine(), out smallNum);
            } while (isSmallNumCheck == false);

            Console.WriteLine("끝 수를 입력해주세요");
            isBigNumCheck = int.TryParse(Console.ReadLine(), out bigNum);
            //예외처리해야할 것
            //1. 숫자가 아닌 다른걸 입력했을 때
            if (isBigNumCheck == false)
            {
                while (isBigNumCheck == false)
                {
                    Console.WriteLine("이상한 문자를 입력하셨습니다. 끝 수를 입려해주세요.");
                    isBigNumCheck = int.TryParse(Console.ReadLine(), out bigNum);
                }
            }
            //2. 기입한 숫자가 처음 입력한 수보다 작을 때
            else if (smallNum > bigNum)
            {
                while (smallNum > bigNum)
                {
                    Console.WriteLine("해당 수는 시작하는 작은 수보다 작습니다. 큰 수를 입력해주세요");
                    isBigNumCheck = int.TryParse(Console.ReadLine(), out bigNum);
                }
            }

            for (int i = smallNum; i <= bigNum; i++)
            {
                result += i;
            }

            Console.WriteLine($"{smallNum}과 {bigNum} 사이의 합은 {result} 입니다.");
        }
    }
}
