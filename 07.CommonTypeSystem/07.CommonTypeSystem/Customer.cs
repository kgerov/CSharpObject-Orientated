using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace _07.CommonTypeSystem
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstname, string middlename, string lastname, string egn, string address, 
            string mobile, string email, List<Payment> payments, CustomerType type)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.EGN = egn;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EGN { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public CustomerType Type { get; set; }

        public override bool Equals(object obj)
        {
            Customer compareTo = obj as Customer;

            if (compareTo == null)
            {
                return false;
            }

            if ((!this.FirstName.Equals(compareTo.FirstName)) || (!this.LastName.Equals(compareTo.LastName)))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return Customer.Equals(c1, c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !Customer.Equals(c1, c2);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Customer: {0} {1} {2} | ID: {3}", this.FirstName, this.MiddleName, this.LastName, this.EGN);
        }

        public object Clone()
        {
            return JsonConvert.DeserializeObject<Customer>(JsonConvert.SerializeObject(this));
        }

        public int CompareTo(Customer other)
        {
            if (this.Equals(other))
            {
                return this.EGN.CompareTo(other.EGN);
            }
            else
            {
                return String.Format(this.FirstName + this.LastName).CompareTo(other.FirstName + other.LastName);
            }
        }
    }
}
