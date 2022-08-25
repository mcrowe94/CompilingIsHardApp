using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    internal class Program
    {
        static int Main(string[] args)
        {            
            Console.WriteLine("Hello!");
            Console.WriteLine("Please give me a number");
            userNumber = Console.ReadLine();
            Console.WriteLine("Please give me another number");
            userNumber = Console.ReadLine();
            answer = userNumber / userNumber;
            Console.WriteLine("{userNumber} / {userNumber} = {answer}");
            Console.WriteLine("Please give me your age!");
            const int USER_AGE = Console.ReadLine();
            if (USER_AGE == 21)
            {
                Console.WriteLine("You may drink alcohol!");
            }
            Console.WriteLine("Give me the name of everyone that lives in your house separated by commas");
            string[] names = Console.ReadLine().Split('\u002C');
            List<Person> people = new List<Person>();
            foreach (Person name in name)
            {
                Person p = new Person();
                p.Name == name;
                Console.WriteLine("What is {name}'s date of birth?");
                p.Dob = Console.ReadLine();
                people.Add(p);
            }
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            var something = DoSomething();
            Console.WriteLine("What is your favorite color?");
            switch (Console.ReadLine().ToUpper())
            {
                case "red":
                    Console.WriteLine("Red is great!");
                case: "blue":
                    Console.WriteLine("Blue is awesome!");
                case: "yellow":
                    Console.WriteLine("Yellow reminds me of the sun");
                case: "orange":
                    Console.WriteLine("I like orange juice!");
                case: "blue":
                    Console.WriteLine("Blue is awesome!");
                default:
                    Console.WriteLine("Never heard of that color, what does it look like?");                    
            }
            try
            {
                Random random = new Random();
                if (random.Next(1,100) % 2 = 0)
                {
                    throw new NullReferenceException();
                }
                else (if random.Next(1, 100) % 3 = 0)
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("The world is good");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Henlooooo");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);                
            }

            return -1;
        }

        void DoSomething()
        {
            Console.WriteLine("I am doing something!");
            return 15;
        }
    }
}
