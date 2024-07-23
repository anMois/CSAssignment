namespace OOP_Abstraction
{
    public class Program
    {
        //추상 클래스 - 클래스를 정의할 당시 구체화 시킬 수 없는 기능을 추상적 표현으로 정의
        //오버라이딩 - 부모클래스의 가상함수를 같은 함수이름과 같은 매개변수로 재정의하여 자식만의 반응을 구현
        //오버로딩 - 같은 함수를 다양하게 사용하는 것 (매개변수를 통하여)
        static void Main(string[] args)
        {
            Gun pistol = new Pistol(300);
            Gun ar = new AssultRifle(30, 5000);
            Gun sg = new ShootGun(10, 2500);
            Gun rl = new Rifle(5, 55000);

            pistol.BuyGun();
            pistol.Shot();
            pistol.Damage(5);

            ar.BuyGun();
            ar.Shot();
            ar.Damage(7);

            sg.BuyGun();
            sg.Shot();
            sg.Damage(12);
            sg.Damage();

            rl.BuyGun();
            rl.Shot();
            rl.Damage(25);
        }
    }
}
