using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispacher
{
    class HTMLTester
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*2);

            ElementBuilder li = new ElementBuilder("li");
            Console.WriteLine(li * 4);

            Console.WriteLine(HTMLDispatcher.CreateImage("softuni.com/logo.png", "Logo", "Vector Logo SoftUni"));
            string url = HTMLDispatcher.CreateURL("www.kufte.com", "Kuftence", "The Kufte is muy delicious");
            Console.WriteLine(url);
            Console.WriteLine(HTMLDispatcher.CreateInput("submit", "reg", "Register!"));
        }
    }
}
