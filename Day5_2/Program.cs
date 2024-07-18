﻿namespace Day5_2
{
    internal class Program
    {
        #region XYCoord
        //short형x, short형y 두가지를 가진 XYCoord라는 구조체를 선언한다.
        struct XYCoord
        {
            public short x;
            public short y;
        }
        #endregion

        #region Weapon
        //정수형 Dmg, 실수형 Critical, 문자열형 Name을 가진 구조체 틀을 만들고 구조체 이름은 Weapon으로 선언한다.
        struct Weapon
        {
            public int Dmg;
            public float Critical;
            public string Name;
        }
        #endregion

        #region Car
        //Car라는 구조체를 만든 후, 다음의 내부 속성을 추가한다.
        //실수형 최고속도
        //정수형 자동차넘버
        //열거형 제조사(Honda, Audi, BMW, Kia 네가지 열거 속성 보유)
        enum CarMaker
        {
            Honda, Audi, BMW, Kia
        }
        struct Car
        {
            public float maxSpeed;
            public int number;
            public CarMaker carMaker;
        }
        #endregion

        #region Item
        //Item 이라는 구조체를 만든다.
        //이 아이템이라는 구조체는 문자열형인 아이템 이름,
        //정수형인 가격, 열거형인 아이템 타입(방어구, 무기, 소모품) 의 속성을 가진다.
        enum ItemType
        {
            Armor, Weapon, Useiteam, SIZE
        }
        struct Item
        {
            public string name;
            public int price;
            public ItemType type;
        }
        #endregion

        static void Main(string[] args)
        {
            //방금 만들어진 구조체 틀을 활용하여,
            //Sword와 Katana라는 객체를 만든 후,
            //본인이 원하는 수치를 각각 속성에 전부 추가한다.
            Weapon Sword = new Weapon();
            Sword.Name = "묵직한 대검";
            Sword.Dmg = 150;
            Sword.Critical = 10.0f;

            Weapon Katana = new Weapon();
            Katana.Name = "화염의 카타나";
            Katana.Dmg = 65;
            Katana.Critical = 50.0f;

            //아이템이 3개 들어가는 인벤토리라는 배열을 만들고,
            //배열 속 세번째 요소에, 아이템명으로 “악몽의 꽃 견갑”, 가격은 500, 아이템의 타입은 방어구이다.
            Item[] inventory = new Item[3];

            inventory[2].name = "악몽의 꽃 견갑";
            inventory[2].price = 500;
            inventory[2].type = ItemType.Armor;
        }

        #region 함수
        //인벤토리의 모든 속 내용을 출력하는 함수를 작성한다.
        static void PrintItem(Item[] _inventory)
        {
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine($"아이템 명 : {_inventory[i].name}");
                Console.WriteLine($"가격 : {_inventory[i].price}");
                Console.WriteLine($"아이템 타입 : {_inventory[i].type}");
                Console.WriteLine("-----------------------------");
            }
        }
        #endregion
    }
}
