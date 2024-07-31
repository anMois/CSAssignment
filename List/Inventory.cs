using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //아이템 저장 및 제거
    public class Inventory
    {
        List<Item> items = new List<Item>(9);

        public void RandomGetItem()
        {
            Random rand = new Random();

            int randNum = rand.Next(1, 6);

            switch (randNum)
            {
                case 1:
                    GetPosion();
                    break;
                case 2:
                    GetWeapon();
                    break;
                case 3:
                    GetArmor();
                    break;
                case 4:
                    GetAccessory();
                    break;
                case 5:
                    GetFood();
                    break;
            }
        }

        public void GetPosion()
        {
            Item potion = new Potion("포션");
            items.Add(potion);
        }
        public void GetWeapon()
        {
            Item weapon = new Weapon("무기");
            items.Add(weapon);
        }
        public void GetArmor()
        {
            Item armor = new Armor("방어구");
            items.Add(armor);
        }
        public void GetAccessory()
        {
            Item accessory = new Accessory("악세서리");
            items.Add(accessory);
        }
        public void GetFood()
        {
            Item food = new Food("음식");
            items.Add(food);
        }

        public void DeleteItem(string _index)
        {
            int.TryParse(_index, out int num);

            items.RemoveAt(num - 1);
        }

        public void PrintInventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 현 상황");
            Console.WriteLine("-----------------");
            
            for (int i = 0; i < items.Capacity; i++)
            {

            }
        }
    }
}
