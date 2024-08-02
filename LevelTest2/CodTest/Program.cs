using System.Collections;

namespace CodTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = new List<int>();

            lists.Add(1);
            lists.Add(1);
            lists.Add(3);
            lists.Add(3);
            lists.Add(0);
            lists.Add(1);
            lists.Add(1);


            foreach (int i in Solution(lists))
            {
                Console.Write(i + " ");
            }
        }


        public static List<int> Solution(List<int> arry)
        {
            List<int> answer = new List<int>();

            for (int i = 0; i < arry.Count; i++)
            {
                int temp = arry[i];
                if (i == 0)
                {
                    answer.Add(temp);
                }
                //answer의 해당 값이 있는 지 확인 후 
                //arry의 i번째와 그 전꺼를 비교해서 다른지 확인 
                //answer에 해당 값이 있어도 arry의 순번으로 전의 값과 체크해서
                //같으면 false고 다르면 true로 처리해서 answer의 값을 추가한다.
                else if (!answer.Contains(temp) || arry[i] != arry[i - 1])
                {
                    answer.Add(temp);
                }
            }

            return answer;
        }
    }
}
