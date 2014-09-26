using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [Version(2, 3)]
    public class GenericList<T> where T : IComparable<T>
    {
        const int DefaultSize = 16;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity = DefaultSize)
        {
            if (capacity < 1)
            {
                throw new ArgumentException("Size has to be more than or equal to 1");
            }
            elements = new T[capacity];
        }

        private T[] doubleSize(T[] elements)
        {
            T[] el2 = new T[this.elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                el2[i] = elements[i];
            }

            return el2;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (this.count >= this.elements.Length-1)
            {
                this.elements = doubleSize(this.elements);
            }
            this.elements[count] = element;
            count++;
        }

        public void Remove(int index)
        {
            IsIndexInRange(index);

            count--;
            for (int i = index; i < count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[count] = default(T);
        }
        public void Insert(int index, T value)
        {
            IsIndexInRange(index, true);
            Add(value);
            T[] el1 = new T[index+1];
            T[] el2 = new T[count-index-1];
            for (int i = 0; i < index+1; i++)
            {
                el1[i] = elements[i];
            }
            el1[index] = value;
            for (int i = index, j = 0; i < count-1; i++, j++)
            {
                el2[j] = elements[i];
            }
            int array1OriginalLength = el1.Length;
            Array.Resize<T>(ref el1, array1OriginalLength + el2.Length);
            Array.Copy(el2, 0, el1, array1OriginalLength, el2.Length);
            this.elements = el1;
        }

        public void Clear()
        {
            Array.Clear(this.elements, 0, this.elements.Length);
        }

        public int getIndex(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool inList(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
        
        public T this[int index]
	    {
		    get
		    {
                IsIndexInRange(index);
                return this.elements[index];
	       }
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        private void IsIndexInRange(int index, bool isInsert = false)
        {
            if (index < 0 || index >= count)
            {
                if (!(isInsert == true && index == count))
                {
                    throw new IndexOutOfRangeException(String.Format("Index must be between 0 and {0}", count));
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += i + ". " +this.elements[i] + "\n";
            }
            return result;
        }
    }
}
