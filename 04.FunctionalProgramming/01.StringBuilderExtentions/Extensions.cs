using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.StringBuilderExtentions
{
    static class Extensions
    {
        public static string Substring(this StringBuilder str, int startIndex, int length) 
        {
            string sub = "";
            try
            {
                for (int i = startIndex; i < startIndex + length; i++)
                {
                    sub += str[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException(String.Format("Index should be between [0...{0})", str.Length));
            }
            return sub;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text)
        {
            return str.Replace(text, "");
        }

        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(item.ToString());
            }

            return str;
        } 
    }
}
