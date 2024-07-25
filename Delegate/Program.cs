namespace Delegate
{
    public class Program
    {
        public class Player
        {
            private Armor curArmor;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor;
                curArmor.OnBreaked += UnEquip;
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor.OnBreaked -= UnEquip;
                curArmor = null;
            }

            public void Hit()
            {
                Console.WriteLine("피해를 입었습니다.");
                curArmor.DecreadeDurability();
            }
        }

        public class Armor
        {
            public string name;
            private int duravility;

            public event Action OnBreaked;

            public Armor(string name, int durability)
            {
                this.name = name;
                this.duravility = durability;
            }

            public void DecreadeDurability()
            {
                duravility--;
                if(duravility <= 0)
                {
                    Break();
                }
            }

            private void Break()
            {
                Console.WriteLine("장비가 내구도가 다 닳아 부서졌습니다.");

                if (OnBreaked != null)
                    OnBreaked();
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor armor = new Armor("감옷", 3);

            player.Equip(armor);

            player.Hit();
            player.Hit();
            player.Hit();
        }
    }
}
