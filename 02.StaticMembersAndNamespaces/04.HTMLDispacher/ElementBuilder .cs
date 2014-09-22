using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispacher
{
    class ElementBuilder
    {
        private string element;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();
        private string content;
        private bool isSingleTag;

        public ElementBuilder(string element, bool isSingleTag = false)
        {
            this.Element = element;
            this.isSingleTag = isSingleTag;
        }

        public string Element 
        {
            get { return this.element; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid element");
                }
                this.element = value;
            }
        }

        public void AddAttribute(string type, string content)
        {
            if (String.IsNullOrEmpty(type) || String.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Invalid attribute");
            }
            this.attributes.Add(type, content);
        }

        public void AddContent(string content)
        {
            if (String.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Invalid attribute");
            }
            if (isSingleTag)
            {
                throw new ArgumentException("Content is not supported by this tag");
            }
            this.content = content;
        }
        public static string operator *(ElementBuilder el, int mult)
        {
            return String.Concat(Enumerable.Repeat(el, mult));
        }

        public override string ToString()
        {
            string result = "<" + this.element;
            foreach (var att in this.attributes)
            {
                result += String.Format(" {0}=\"{1}\"", att.Key, att.Value);
            }
            if (isSingleTag)
            {
                result += ">";
            }
            else
            {
                result += String.Format(">{0}</{1}>", this.content, this.element);
            }
            return result;
        }
    }
}
