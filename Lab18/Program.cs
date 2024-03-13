namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }

        static string Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>
            {
                {'(',')'},
                {'[',']'},
                {'{','}'}

            };


            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                { stack.Push(dict[c]); }

                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count==0||stack.Pop()!=c)
                    {
                        return "Скобки расставлены некорректно";
                    }
                    
                }

            }

            if (stack.Count==0)
            {
                return "Скобки расставлены корректно";
            }

            else return "Скобки расставлены некорректно";
        }
    }
}
