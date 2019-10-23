using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProg
{
    class Customer
    {
        private string FName;
        private string LName;
        private string Phone;

        public string fName { get { return FName; } set { FName = value; } }
        public string lName { get { return LName; } set { LName = value; } }
        public string phone { get { return Phone; } set { Phone = value; } }

        public Customer(string fName, string lName, string phone)
        {
            Console.Write("***Customer Object has been Created***");
            FName = fName;
            LName = lName;
            Phone = phone;
        }
        public Customer()
        {

        }
        public string GetCustomer()
        {
            return $"Full Name: {fName} {lName}  |  Phone Number: {phone}";
        }
    }
}
