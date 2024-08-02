using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public enum JobType { Attacker, Defanser, Supporter, Healer, Specialist }
    
    public class MonsterData
    {
        public string name;
        public JobType type;
        public int hp;
        public int attak;
        public int defanse;

        public MonsterData(string _name, JobType _type, int _hp, int _atk, int _def)
        {
            this.name = _name;
            this.type = _type;
            this.hp = _hp;
            this.attak = _atk;
            this.defanse = _def;
        }
    }

    public class Monster
    {
        public string name;
        public JobType type;
        public int hp;
        public int attak;
        public int defanse;

        public Monster(MonsterData _data)
        {
            this.name = _data.name;
            this.type = _data.type;
            this.hp = _data.hp;
            this.attak = _data.attak;
            this.defanse = _data.defanse;                
        }
    }
}
