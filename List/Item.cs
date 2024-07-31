namespace List
{
    public class Item
    {
        public string name;          //아이템 이름

        public Item(string _name)
        {
            name = _name;
        }
    }

    public class Potion : Item
    {
        public Potion(string _name) : base(_name)
        {
            base.name = _name;
        }
    }

    public class Weapon : Item
    {
        public Weapon(string _name) : base(_name)
        {
            base.name = _name;
        }
    }

    public class Armor : Item
    {
        public Armor(string _name) : base(_name)
        {
            base.name = _name;
        }
    }

    public class Accessory : Item
    {
        public Accessory(string _name) : base(_name)
        {
            base.name = _name;
        }
    }

    public class Food : Item
    {
        public Food(string _name) : base(_name)
        {
            base.name = _name;
        }
    }
}
