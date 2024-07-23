using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    public abstract class Gun
    {
        private int bullet;
        protected int maxBullet;
        public int price;

        public Gun(int _price)
        {
            this.maxBullet = 8;
            this.bullet = maxBullet;
            this.price = _price;
        }

        public abstract void Shot();
        public void Damage()
        {
            Console.WriteLine("총을 가지고 때렸습니다.");
        }
        public void Damage(int _damage)
        {
            Console.WriteLine($"{_damage}의 피해를 입었습니다.");
        }

        public void BuyGun()
        {
            Console.WriteLine($"{price} 가격으로 구매했습니다");
        }
    }

    public class Pistol : Gun
    {
        public Pistol(int _price) : base(_price)
        {
            base.price = _price;
        }

        public override void Shot()
        {
            Console.WriteLine("탕!탕!탕!");
        }
    }
    public class AssultRifle : Gun
    {
        public AssultRifle(int _bullet, int _price) : base(_price)
        {
            base.maxBullet = _bullet;
            base.price = _price;
        }

        public override void Shot()
        {
            Console.WriteLine("두두두! 두두두!");
        }
    }
    public class ShootGun : Gun
    {
        public ShootGun(int _bullet, int _price) : base(_price)
        {
            base.maxBullet = _bullet;
            base.price = _price;
        }

        public override void Shot()
        {
            Console.WriteLine("팡! 철컥!");
        }
    }
    public class Rifle : Gun
    {
        public Rifle(int _bullet, int _price) : base(_price)
        {
            base.maxBullet = _bullet;
            base.price = _price;
        }

        public override void Shot()
        {
            Console.WriteLine("투왕! 철컥!");
        }
    }
}
