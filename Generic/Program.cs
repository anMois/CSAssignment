namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<Potion> potionInventory = new(10);    //포션에 관한 인벤토리 생성 크기는 10인

            potionInventory.Add(new Potion("체력 포션"));   //체력 포션 추가
            potionInventory.Add(new Potion("마나 포션"));   //마나 포션 추가
            potionInventory.Add(new Potion("경험치 포션")); //경험치 포션 추가
            potionInventory.Add(new Potion("활력 포션"));   //활력 포션 추가

            potionInventory.Remove();   //포션 하나 제거
            potionInventory.Remove();   //포션 하나 제거

            potionInventory.PrintItemNames();   //보유한 포션 출력
        }
    }

    //Item이라는 추상클래스 생성
    public abstract class Item
    {
        public string Name { get; private set; }    //이름

        //Item 생성자
        public Item(string name)
        {
            Name = name;
        }
    }

    //Item을 상속 받는 Potion클래스 생성
    public class Potion : Item
    {
        //Potion 생성자
        public Potion(string name) : base(name) { }
    }

    // T에는 'Itme'을 상속받은 클래스만 넣을 수 있다.
    public class Inventory<T> where T : Item
    {
        private T[] _lists; //T(Item)을/를 넣을 수 있는 배열
        private int _index; //인덱스

        //Inventory 생성자
        public Inventory(int size)
        {
            _lists = new T[size]; //size의 크기의 T(Item)배열 초기화
        }

        //추가 기능
        public void Add(T item)
        {
            //index가 lists의 길이보다 작을 경우 index번째에 해당한 lists에 item을 넣고 index증가
            if(_index < _lists.Length)
            {
                _lists[_index] = item;
                _index++;
            }
        }

        //삭제 기능
        public void Remove()
        {
            //index가 0보다 클때 index를 감소시키고 감소한 index번째 lists를 null값 대입
            if(_index > 0)
            {
                _index--;
                _lists[_index] = null;
            }
        }

        //보유중인  Item을 출력하는 함수
        public void PrintItemNames()
        {
            Console.WriteLine("아이템 목록 : ");

            //lists에 있는 것을 item으로 하나하나 옮기기
            foreach(T item in _lists)
            {
                //item이 비어있지 않으면 item의 이름 출력
                if(item != null)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

    }

}
