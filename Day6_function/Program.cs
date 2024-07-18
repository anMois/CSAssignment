namespace Day6_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SelectBigNum(1, 36, 442, 42);
            //Console.WriteLine(AddBigNum(0.1f, 16.7f, 3.6f, 44.2f, 4.2f));
            //Console.WriteLine(SubtrationNum(100, 200));

            //Console.WriteLine(SelectThreeOrFive(100));
            //Console.WriteLine(AddSeatNumber(123));
            //Console.WriteLine(Fibonacci(20));
        }

        #region 기본 과제
        //과제 1. 다수의 인자값 요구 함수 구현
        static void SelectBigNum(int _one, int _two, int _three, int _four)
        {
            int[] numArr = new int[] { _one, _two, _three, _four };
            int bigNum = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                if (bigNum <= numArr[i])
                {
                    bigNum = numArr[i];
                }
            }

            Console.WriteLine($"4개의 수 중 가장 큰 수는 {bigNum} 이다.");
        }

        //과제 2. 다수의 인자값 및 반환형을 가진 함수 구현
        static float AddBigNum(float _one, float _two, float _three, float _four, float _five)
        {
            float[] numArr = new float[] { _one, _two, _three, _four, _five };
            float bigNum1 = numArr.Max();
            float bigNum2 = 0.0f;

            //가장 큰수 찾기
            for (int i = 0; i < numArr.Length; i++)
            {
                if (bigNum1 <= numArr[i])
                {
                    bigNum2 = bigNum1;
                    bigNum1 = numArr[i];
                }
            }

            //두번째로 큰수 찾기
            for (int i = 0; i < numArr.Length; i++)
            {
                if (bigNum2 <= numArr[i] && numArr[i] != bigNum1)
                {
                    bigNum2 = numArr[i];
                }
            }

            return bigNum1 + bigNum2;
        }

        //과제 3. 특정 조건을 포함한 함수 제작
        static bool SubtrationNum(int _one, int _two)
        {
            if (_one <= _two)
                return _two - _one < 100 ? true : false;
            else
                return _one - _two < 100 ? true : false;
        }
        #endregion

        #region 심화 과제
        //심화 과제 1. 복합조건을 가진 함수 제작
        static int SelectThreeOrFive(int _num)
        {
            int sum = 0;

            for (int i = 1; i <= _num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        //심화 과제 2. 자릿수 합 디코더 제작 인터넷... 참조...
        //자릿수 만드는 패턴은 자필로 해서 만들었으나
        //조건식에서 막힘
        static int AddSeatNumber(int _num)
        {
            int seatNum = 0;

            while (_num > 0)
            {
                seatNum += _num % 10;
                _num /= 10;
            }

            return seatNum;
        }

        //심화 과제 4. 피보나치 함수 제작
        static int Fibonacci(int _value)
        {
            int[] num = new int[_value];

            for (int i = 0; i < num.Length; i++)
            {
                if (i == 0 || i == 1)
                    num[i] = 1;
                else
                    num[i] = num[i - 1] + num[i - 2];
            }

            return num[_value - 1];
        }
        #endregion
    }
}
