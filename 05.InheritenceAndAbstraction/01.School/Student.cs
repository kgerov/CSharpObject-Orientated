using System;

namespace _01.School
{
    class Student : Person, IDetails
    {
        public int UClassNumber { get; set; }
        public string Details { get; set; }

        public Student(string name, int UClassNUmber, string Details = null) 
            : base(name)
        {
            this.UClassNumber = UClassNumber;
            this.Details = Details;
        }
    }
}
