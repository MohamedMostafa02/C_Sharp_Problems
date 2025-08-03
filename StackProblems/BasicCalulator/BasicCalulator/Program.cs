using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BasicCalulator
{
    internal class Program
    {
        static int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            int result = 0, sign = 1,num = 0;

            foreach (char c in s)
            {
                if(char.IsDigit(c))
                {
                    num = num * 10 + c - '0';
                }
                else if(c == '+')
                {
                    result += sign * num;
                    num = 0;
                    sign = 1;
                }
                else if(c == '-')
                {
                    result += sign * num;
                    num = 0;
                    sign = -1;
                }
                else if(c == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if(c == ')')
                {
                    result += sign * num;
                    num = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                }
            }
            result += sign * num;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate("1 + (5 - 3)"));
            Console.ReadKey();
        }
    }
}
