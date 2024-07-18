namespace Day5_1
{
    internal class Program
    {
        enum Map
        {
            마을 = 1, 사냥터, 상점
        }

        enum State
        {
            Idle = 1, Run, Walk, DIE = 9
        }

        static void Main(string[] args)
        {
            #region 과제 1. 열거형 리팩토링
            //Console.WriteLine("이동 할 장소를 설정해주세요");
            //Console.WriteLine("1. 마을 | 2. 사냥터 | 3. 상점");
            //Map map;
            //
            //Enum.TryParse(Console.ReadLine(), out map);
            //Console.Clear();
            //
            //switch (map)
            //{
            //    case Map.마을:
            //        Console.WriteLine("마을로 이동합니다.");
            //        break;
            //    case Map.사냥터:
            //        Console.WriteLine("사냥터로 이동합니다.");
            //        break;
            //    case Map.상점:
            //        Console.WriteLine("상점으로 이동합니다.");
            //        break;
            //    default:
            //        Console.WriteLine("1, 2, 3 어느것도 아니에요");
            //        break;
            //}
            #endregion

            #region 과제 2. 상태를 열거형으로 구현
            State state;

            do
            {
                Console.WriteLine("다음 당신의 행동을 선택하시오.");
                Console.WriteLine("1. 기본 | 2. 달리기 | 3. 걷기 | 9. 죽음 |");
                Console.Write("입력 : ");
                Enum.TryParse(Console.ReadLine(), out state);
                if (!Enum.IsDefined(typeof(State),state))
                    Console.WriteLine("옳지 못한 입력을 하였습니다. 다시 입력해주세요");
            } while (state <= 0 || 3 < (int)state && (int)state != 9);

            switch (state)
            {
                case State.Idle:
                    Console.WriteLine("현재 기본 상태입니다.");
                    break;
                case State.Run:
                    Console.WriteLine("현재 달리기 상태입니다.");
                    break;
                case State.Walk:
                    Console.WriteLine("현재 걷기 상태입니다.");
                    break;
                case State.DIE:
                    Console.WriteLine("현재 죽은 상태입니다.");
                    break;
            }
            #endregion
        }
    }
}
