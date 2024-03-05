using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScotRail
{
    abstract class Customer
    {
        private static int nextCustomerID = 1;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public int CustomerID { get; private set; }

        public abstract decimal Discount();

        protected Customer(string firstName, string lastName, string email)
        {
            CustomerID = nextCustomerID++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }

    class FirstClass : Customer
    {
        public FirstClass(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
        }

        public override decimal Discount()
        {
            return 0.10m;
        }
    }

    class SecondClass : Customer
    {
        public SecondClass(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
        }

        public override decimal Discount()
        {
            return 0.0m;
        }
    }
}
