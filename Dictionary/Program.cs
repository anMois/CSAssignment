namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, MonsterData> monsterData = new Dictionary<string, MonsterData>();

            monsterData.Add("가드", new MonsterData("가드", JobType.Attacker, 120, 150, 100));
            monsterData.Add("디펜더", new MonsterData("디펜더", JobType.Defanser, 150, 80, 200));
            monsterData.Add("서포터", new MonsterData("서포터", JobType.Supporter, 100, 100, 100));
            monsterData.Add("힐러", new MonsterData("힐러", JobType.Healer, 100, 70, 80));
            monsterData.Add("스페셜리스트", new MonsterData("스페셜리스트", JobType.Specialist, 100, 250, 70));


            Monster guard = new Monster(monsterData["가드"]);

            PrintMonster(guard);
        }

        static void PrintMonster(Monster _monster)
        {
            Console.WriteLine($"이  름 : {_monster.name}");
            Console.WriteLine($"타  입 : {_monster.type}");
            Console.WriteLine($"체  력 : {_monster.hp}");
            Console.WriteLine($"공격력 : {_monster.attak}");
            Console.WriteLine($"방어력 : {_monster.defanse}");
        }
    }
}
