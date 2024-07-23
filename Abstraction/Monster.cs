namespace Abstraction
{
    public enum MobType { Electric, Fire, Water, Grass }

    public abstract class Monster
    {
        public int level;
        protected MobType mobType;
        public string name;
        public int hp;

        public Monster(string _name, int _level)
        {
            this.name = _name;
            this.level = _level;
        }

        public abstract void BaseAttack();
    }

    public class Pikachu : Monster
    {
        public Pikachu(string _name, int _level, MobType _mobType) : base(_name, _level)
        {
            base.name = _name;
            base.level = _level;
            base.mobType = _mobType;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("전광석화");
        }
    }
    public class Squirtle : Monster
    {
        public Squirtle(string _name, int _level, MobType _mobType) : base(_name, _level)
        {
            base.name = _name;
            base.level = _level;
            base.mobType = _mobType;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("물총발사");
        }
    }
    public class Bulbasaur : Monster
    {
        public Bulbasaur(string _name, int _level, MobType _mobType) : base(_name, _level)
        {
            base.name = _name;
            base.level = _level;
            base.mobType = _mobType;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("덩쿨채찍");
        }
    }
    public class Charmander : Monster
    {
        public Charmander(string _name, int _level, MobType _mobType) : base(_name, _level)
        {
            base.name = _name;
            base.level = _level;
            base.mobType = _mobType;
        }

        public override void BaseAttack()
        {
            Console.WriteLine("화염방사");
        }
    }
}
