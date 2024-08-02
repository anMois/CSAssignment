using System.ComponentModel.Design;

namespace StackQueue
{
    internal class Program
    {
        //괄호 탐색기
        //[], {}, ()
        //열려있는 체크, 열려있으면 닫혔는지 체크
        //열려있으면 열린 괄호 확인 해당 괄호가 닫혔는지 체크
        static void Main(string[] args)
        {
            Stack<char> openStr = new Stack<char>();


            Console.Write("입력 : ");
            string str = Console.ReadLine();

            OpenCheck(str, openStr);
            if (CloseCheck(str, openStr))
                Console.WriteLine("가능");
            else
                Console.WriteLine("불가능");
        }

        public static void OpenCheck(string _str ,Stack<char> _strs)
        {
            for (int i = 0; i < _str.Length; i++)
            {
                if (_str[i].Equals('('))
                    _strs.Push('(');
                else if (_str[i].Equals('{'))
                    _strs.Push('{');
                else if(_str[i].Equals('['))
                    _strs.Push('[');
            }
        }

        public static bool CloseCheck(string _str, Stack<char> _strs)
        {
            for (int i = 0; i < _str.Length; i++)
            {
                if (_strs.Contains('(') && _str[i].Equals(')'))
                {
                    _strs.Pop();
                    if (_strs.Count != 0)
                        continue;
                    else
                        return true;
                }
                else if (_strs.Contains('{') && _str[i].Equals('}'))
                {
                    _strs.Pop();
                    if (_strs.Count != 0)
                        continue;
                    else
                        return true;
                }
                else if (_strs.Contains('[') && _str[i].Equals(']'))
                {
                    _strs.Pop();
                    if (_strs.Count != 0)
                        continue;
                    else
                        return true;
                }
            }

            return false;
        }
    }
}
