namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer("트레이너 A");
            
            trainer.AddMonster(1, new Charmander("파이리", 5, MobType.Fire));

            trainer.AllAttack();
        }
    }
}
