using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.StringDisperser
{
    public class StringDisperser : ICloneable,  IComparable<StringDisperser>, IEnumerable<char>
    {
        private string[] parts;

        public StringDisperser(params string[] args)
        {
            this.Parts = args;
        }

        public string[] Parts
        {
            get { return this.parts; }
            set
            {
                this.parts = value;
            }
        }

        public override bool Equals(object obj)
        {
            StringDisperser com = obj as StringDisperser;

            if (com == null)
            {
                return false;
            }

            if (!String.Join("", parts).Equals(String.Join("", com.parts)))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(StringDisperser s1, StringDisperser s2) 
        {
            return StringDisperser.Equals(s1, s2);
        }

        public static bool operator !=(StringDisperser s1, StringDisperser s2)
        {
            return !StringDisperser.Equals(s1, s2);
        }

        public override int GetHashCode()
        {
            char[] charArray = this.ToString().ToCharArray();
            Array.Reverse(charArray);
            string revObj = new string(charArray);
            return this.ToString().GetHashCode() ^ revObj.GetHashCode();
        }

        public override string ToString()
        {
            return String.Join(", ", this.parts);
        }

        public IEnumerator<char> GetEnumerator()
        {
            string partsStr = String.Join("", this.Parts);

            for (int i = 0; i < partsStr.Length; i++)
            {
                yield return partsStr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(StringDisperser other)
        {
            return String.Join("", this.parts).CompareTo(String.Join("", other.parts));
        }

        public object Clone()
        {
            return new StringDisperser(this.parts);
        }
    }
}
