using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string Address { get; set; }
        public DateTime Dob { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
       //public string Name { get; set; }

        //private int numberOfLegs = 0;
        //public int NumberOfLegs { get; init; } = numberOfLegs;

        public static string SayName(string name)
        {
            return $"My name is {name}";
        }

    }
}
