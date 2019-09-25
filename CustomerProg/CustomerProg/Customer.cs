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
        private int Phone;

        public string fName { get { return FName; } set { FName = value; } }
        public string lName { get { return LName; } set { LName = value; } }
        public int phone { get { return Phone; } set { Phone = value; } }

        public Customer(string fName, string lName, int phone)
        {
            Console.Write("***Customer Object has been Created***");
            FName = fName;
            LName = lName;
            Phone = phone;
        }
        public string GetCustomer()
        {
            return $"First Name: {fName}\nLast Name: {lName}\nPhone Number: {phone}";
        }
    }
}
