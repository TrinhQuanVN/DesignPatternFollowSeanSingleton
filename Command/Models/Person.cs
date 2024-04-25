using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    public class Person
    {
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
