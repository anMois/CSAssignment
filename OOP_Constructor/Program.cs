namespace OOP_Constructor
{
    internal class Program
    {
        public class Trainer
        {
            public string name;
            public Monster[] monster;

            public Trainer(string _name)
            {
                name = _name;
                monster = new Monster[6];
            }

            public void AddMonster(Monster _monster)
            {
                _monster = new Monster();
            }

            public void PrintInfo()
            {
                Console.WriteLine($"이름 : {name}");
                Console.WriteLine("보유한 몬스터의 체력");
                for(int i = 0; i < monster.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {monster[i].hp}");
                }
            }
        }

        public class Monster
        {
            public int hp;

            public Monster()
            {
                hp = 10;
            }
        }
    
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer("트레이너A");

            for (int i = 0; i < trainer.monster.Length; i++)
            {
                trainer.AddMonster(trainer.monster[i]);
            }

            trainer.PrintInfo();            
        }
    }
}
