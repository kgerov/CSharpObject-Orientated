using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispacher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img", true);
            img.AddAttribute("src", src);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);
            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder a = new ElementBuilder("a");
            a.AddAttribute("href", url);
            a.AddAttribute("title", title);
            a.AddContent(text);
            return a.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input", true);
            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);
            return input.ToString();
        }
    }
}
