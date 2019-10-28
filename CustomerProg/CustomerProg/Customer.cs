using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProg
{
    public class Customer
    {
        private string FName;
        private string LName;
        private string Phone;

        public string fn { get { return FName; } set { FName = value; } }
        public string ln { get { return LName; } set { LName = value; } }
        public string ph { get { return Phone; } set { Phone = value; } }

        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }
        public Customer()
        {

        }
        public static void Main()
        {
            List<Customer> CustomerDB = new List<Customer>();

            CustomerDB.Add(new Customer { fn = "Jim", ln = "Smith", ph = "346-2514" });
            CustomerDB.Add(new Customer { fn = "Jo", ln = "Baker", ph = "346-1263" });
            CustomerDB.Add(new Customer { fn = "Aimee", ln = "Ellery", ph = "346-3658" });
            CustomerDB.Add(new Customer { fn = "Sam", ln = "Herewini", ph = "346-9898" });
        }
        public string GetCustomer()
        {
            return $"Full Name: {fn} {ln}  |  Phone Number: {ph}";
        }

    }

}
