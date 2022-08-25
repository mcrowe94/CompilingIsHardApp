using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    internal static class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string Address { get; set; }
        public DateTime Dob { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }

        public void SayName()
        {
            Console.WriteLine($"My name is {this.Name}");
        }
    }
}
