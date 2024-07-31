namespace List
{
    public class Program
    {
        //이행해야하는 것
        //숫자키 0누르면 랜덤으로 아이템 획득하고 인벤토리에 추가
        //숫자키 1~9를 누르면 해당된 숫자의 아이템 제거
        static void Main(string[] args)
        {            
            Inventory inven = new Inventory();

            while (true)
            {
                inven.PrintInventory();

                string num = Console.ReadLine();

                switch (num)
                {
                    case "0":
                        inven.RandomGetItem();
                        break;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        inven.DeleteItem(num);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
