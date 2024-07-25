namespace Extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowdID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }
    }
    //'!', '@', '#', '$', '%', '^', '&', '*'
    public static class Extention
    {
        public static bool IsAllowdID(this string _id)
        {
            int count = 0;
            
            for (int i = 0; i < _id.Length; i++)
            {
                switch (_id[i])
                {
                    case '!':
                    case '@':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '*':
                        count++;
                        break;
                }
            }
            
            return count > 0 ? false : true;
        }
    }
}
