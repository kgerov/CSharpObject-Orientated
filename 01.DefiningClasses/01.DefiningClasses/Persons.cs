using System;
using System.Linq;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, null) { }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty name entered!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age should between 1 and 100 inclusive!");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Empty email entered!");
            }
            else if (value != null && value.IndexOf('@') == -1)
            {
                throw new Exception("Invalid email. Email should contain @!");
            }
            else
            {
                this.email = value;
            }
        }
    }

    public override string ToString()
    {
        string sAge = age.ToString();
        return "I am " + name + ". Years Old: " + sAge;
    }
}
class Persons
{
    static void Main(string[] args)
    {
        Person gosho = new Person("Gosho", 56);

        gosho.Email = "asdf@abv.bg";

        Console.WriteLine(gosho.Name);
        Console.WriteLine(gosho.Email);
        Console.WriteLine(gosho.Age);

        Console.WriteLine(gosho);
    }
}