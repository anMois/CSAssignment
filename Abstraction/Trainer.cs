using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Trainer
    {
        public string name;
        Monster[] monsters = new Monster[6];
        
        public Trainer(string _name)
        {
            this.name = _name;
            monsters[0] = new Pikachu("피카츄", 10, MobType.Electric);
        }

        public void AddMonster(int _index, Monster _monster)
        {
            if (monsters[_index] == null)
                monsters[_index] = _monster;
            else
                Console.WriteLine("해당 위치에 몬스터가 있습니다.");
        }

        public void AllAttack()
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == null)
                    continue;

                monsters[i].BaseAttack();
            }
        }
    }
}
