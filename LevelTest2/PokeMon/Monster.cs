using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    public abstract class Monster
    {
        public string name;

        public Monster(string _name)
        {
            this.name = _name;
        }

        public abstract void Attack();
    }

    public class Pikachu : Monster
    {
        public Pikachu() : base("피카츄")
        {

        }

        public Pikachu(string _name) : base(_name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("백만볼트!");
        }
    }

    public class Charmander : Monster
    {
        public Charmander() : base("파이리")
        {

        }

        public Charmander(string _name) : base(_name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("화염방사!");
        }
    }
    public class Squirtle : Monster
    {
        public Squirtle() : base("꼬북이")
        {

        }

        public Squirtle(string _name) : base(_name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("물총발사!");
        }
    }

    public class Bulbasaur : Monster
    {
        public Bulbasaur() : base("이상해씨")
        {

        }

        public Bulbasaur(string _name) : base(_name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("덩굴채찍!");
        }
    }
}
