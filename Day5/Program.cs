namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제 1. 고정 배열 생성 및 출력
            //int[] nums = new int[4];
            //
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{i + 1}번 요소를 입려하십시오 : ");
            //    int.TryParse(Console.ReadLine(), out nums[i]);
            //}
            //
            //Console.WriteLine("입력된 요소는 다음과 같습니다.");
            //foreach (int checkNum in nums)
            //{
            //    Console.WriteLine($" {checkNum}");
            //}
            #endregion

            #region 과제 2. 배열의 요소 변경 및 출력
            //int[,] arryNum = new int[4, 4];
            //int count = 3;
            //
            ////반복문을 통하여 순서대로 3의 배수 넣기
            //for (int i = 0; i < arryNum.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arryNum.GetLength(1); j++)
            //    {
            //        arryNum[i, j] = count;
            //        count += 3;
            //    }
            //}
            //
            ////2열3행 요소와 3행2열 요소 바꾸기
            //int changNum = arryNum[2, 3];
            //arryNum[2, 3] = arryNum[3, 2];
            //arryNum[3, 2] = changNum;
            //
            ////4x4출력
            //for (int i = 0; i < arryNum.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arryNum.GetLength(1); j++)
            //    {
            //        Console.Write($"{arryNum[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 심화 과제 1. 유저의 요구사항에 맞는 배열 및 기능 제작
            string[] inventory;     //사용자가 크기 지정한 인벤토리
            int inventorySize;      //원하는 인베토리 크기
            int selectInventory;    //보고싶은 인벤토리 번호

            bool isInventrySize;    //인벤토리 크기 체크

            //"원하는 인벤토리의 크기를 입력하세요" 출력 후 숫자 입력받기. 1~10 아니면 무한반복
            do
            {
                Console.Write("원하는 인벤토리의 크기를 입력하세요 (1 ~ 10 사이) : ");
                isInventrySize = int.TryParse(Console.ReadLine(), out inventorySize);
            } while (isInventrySize == false || inventorySize <= 0 || inventorySize > 10);

            //"n개 만큼의 인벤토리가 생성되었습니다" 출력
            inventory = new string[inventorySize];
            Console.WriteLine("===================================\n");
            Console.WriteLine($"{inventorySize}개 만큼의 인벤토리가 생성되었습니다.");
            Console.WriteLine("\n===================================");

            while (true)
            {
                //"열람을 원하는 번호를 입력해주시기 바랍니다" 출력 후 유저의 입력 받기
                Console.Write($"열람을 원하는 번호를 입려해주시기 바랍니다 (1 ~ {inventorySize} 사이, 0 - 종료) : ");
                int.TryParse(Console.ReadLine(), out selectInventory);

                //0을 입력받으면 무한반복 종료
                if (selectInventory == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                //칸이 비어있다면("" 이 들어있다면) "칸이 비었습니다. 값을 입력하세요" 출력
                if (inventory[selectInventory - 1] == null)
                {
                    Console.WriteLine($"{selectInventory} 칸이 비었습니다.");
                    Console.Write("해당 인벤토리에 넣을 값을 입력하세요. : ");
                    inventory[selectInventory - 1] = Console.ReadLine();
                }
                //번호에 해당하는 칸에 내용물이 있었다면 해당 내용을 출력
                else
                {
                    Console.WriteLine($"{selectInventory} 칸에는 \"{inventory[selectInventory - 1]}\" 내용물이 있습니다.");
                }
            }
            #endregion
        }
    }
}
