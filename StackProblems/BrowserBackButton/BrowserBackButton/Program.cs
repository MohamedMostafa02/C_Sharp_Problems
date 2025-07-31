using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserBackButton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> history = new Stack<string>();

            history.Push("Page1");
            history.Push("Page2");
            history.Push("Page3");

            Console.WriteLine("Back From: "+ history.Pop()); // output: back from page 3
            Console.WriteLine("Current Page: "+ history.Peek()); 
            Console.ReadKey();
        }
    }
}
