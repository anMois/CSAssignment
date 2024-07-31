using System.Runtime.InteropServices;

namespace ListJosephus
{
    internal class Program
    {
        //필요한 정보
        //해당 인원수, 제거된 n번째 인원, 결과값
        //ex. (7, 3) -> (3, 6, 2, 7, 5, 1, 4)
        static void Main(string[] args)
        {
            LinkedList<int> personList = new(); //해당 인원수를 담을 리스트

            List<int> indexList = new();   //제거된 n번째 인원을 담을 리스트

            int person; //해당 인원수
            int index;  //제거된 n번째 인원


            Insert(out person, out index);

            AddPerson(person, personList);
            FindIndex(personList, index, indexList);

            PrintOutPerson(indexList);
        }

        /// <summary>
        /// 초기 세팅 몇 명으로 이루어져있는지, 몇 번째 인원을 제외할지
        /// </summary>
        public static void Insert(out int _person, out int _index)
        {
            while (true)
            {
                Console.Write("몇 명이서 원을 이루어 앉겠습니까? : ");
                int.TryParse(Console.ReadLine(), out _person);

                Console.Write("몇 번째 인원을 제거하시겠습니까? : ");
                int.TryParse(Console.ReadLine(), out _index);

                if (_person > 0 && _index > 0)
                    return;
            }
        }

        /// <summary>
        /// 지정한 인원수 채워넣기
        /// </summary>
        public static void AddPerson(int _personNum, LinkedList<int> _lists)
        {
            for (int i = 0; i < _personNum; i++)
            {
                _lists.AddLast(i + 1);
            }
        }

        /// <summary>
        /// 정해진 순번인 인원 제외 및 등록
        /// </summary>
        public static void FindIndex(LinkedList<int> _lists, int _index, List<int> _indexs)
        {
            //시작할 때 노드를 첫번째 값부터 시작하기 위해 대입
            LinkedListNode<int> node = _lists.First; 

            while(_lists.Count != 0)
            {
                for (int i = 0; i < _index; i++)
                {
                   if (i == _index - 1)
                    {
                        _indexs.Add(node.Value);    //해당 값을 리스트에 대입

                        //해당 노드를 제거하면 다음에 있을 리스트의 노드를 찾기를 못해
                        //노드를 증가 시킨 후 전의 노드를 제거하는 형태로 설계
                        node = node.Next == null ? _lists.First : node.Next;     
                        _lists.Remove(node.Previous == null ? _lists.Last : node.Previous);
                        
                        break;
                    }
                    else
                    {
                        //노드를 다음노드로 변경 그리고 다음노드가 없을 시 다시 처음 노드로 변경
                        node = node.Next == null ? _lists.First : node.Next;
                    }                     
                }
            }
        }

        /// <summary>
        /// 제외된 인원을 순서대로 출력
        /// </summary>
        public static void PrintOutPerson(List<int> _lists)
        {
            foreach (int num in _lists)
            {
                Console.Write($"{num} | ");
            }
        }
    }
}
