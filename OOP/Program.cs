namespace OOP
{
    internal class Program
    {        
        class Chracter
        {
            public int level;
            public int hp;
            public float moveSpeed;
            public int attack;

            public void MoveFront()
            {
                Console.WriteLine("앞으로 이동");
            }

            public void MoveBack()
            {
                Console.WriteLine("뒤로 이동");
            }

            public void MoveLeft()
            {
                Console.WriteLine("왼쪽으로 90도 회전");
            }

            public void MoveRight()
            {
                Console.WriteLine("오른쪽으로 90도 회전");
            }

            public void Attack(int _atk)
            {
                Console.WriteLine($"{_atk} 만큼의 공격을 하였다.");
            }
            
            public void SufferDamage(int _damage)
            {
                Console.WriteLine($"{_damage} 만큼의 피해를 받았다.");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
