using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class Tester
    {
        static void Main(string[] args)
        {
            var customAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), true);
            Console.WriteLine("This GenericList<T> class's version is {0}", customAttributes[0]);
            //INT LIST
		    GenericList<int> intList = new GenericList<int>(1);
		    //1-5
            intList.Add(1);
		    intList.Add(2);
		    intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            Console.WriteLine("1-5 LIST:");
            Console.WriteLine(intList);

            //Insert
            intList.Insert(5, 6);
            intList.Insert(0, -1);
            intList.Insert(4, 3);
            Console.WriteLine("After Instert:");
            Console.WriteLine(intList);

            //Time for some removal
            intList.Remove(5);
            intList.Remove(6);
            Console.WriteLine("After removal:");
            Console.WriteLine(intList);

            //Remove comment to clear list!
            //intList.Clear();

            //Access index
            Console.WriteLine("Print the list with by accessing elements' index:");
		    Console.WriteLine("Number of elements: {0}", intList.Count);
		    for (int i = 0; i < intList.Count; i++)
		    {
			    int element = intList[i];
			    Console.WriteLine(element);
		    }

            Console.WriteLine("Smallest element is: " + intList.Min());
            Console.WriteLine("Max element is: " + intList.Max());

		    Console.WriteLine();

		    GenericList<string> stringList = new GenericList<string>();
		    stringList.Add("C#");
		    stringList.Add("Java");
		    stringList.Add("PHP");
		    stringList.Add("SQL");
		    Console.WriteLine("Number of elements: {0}", stringList.Count);
		    for (int i = 0; i < stringList.Count; i++)
		    {
			    string element = stringList[i];
			    Console.WriteLine(element);
		    }

            Console.WriteLine("Smallest element is: " + stringList.Min());
            Console.WriteLine("Max element is: " + stringList.Max());
        }
    }
}
