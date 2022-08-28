using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            int exitCode;
            Console.WriteLine("Hello!");
            Console.WriteLine("Please give me a number");

            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give me another number");
            int secondNumber = int.Parse(Console.ReadLine());
            int answer = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {answer}");

            Console.WriteLine("Please give me your age!");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge >= 21)
            {
                Console.WriteLine("You may drink alcohol!");
            }



            Console.WriteLine("Give me the name of everyone that lives in your house separated by commas");
            string[] names = Console.ReadLine().Split('\u002C');
            List<Person> people = new List<Person>();
            foreach (var name in names)
            {
                Person p = new Person();
                p.Name = name;
                Person.SayName(name);
                Console.WriteLine($"What is {name}'s date of birth?");
                p.Dob = DateTime.Parse(Console.ReadLine());
                people.Add(p);
            }



            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }



            DoSomething();


            Console.WriteLine("What is your favorite color?");
            switch (Console.ReadLine().ToLower())
            {
                case "red":
                    Console.WriteLine("Red is great!");
                    break;

                case "blue":
                    Console.WriteLine("Blue is awesome!");
                    break;

                case "yellow":
                    Console.WriteLine("Yellow reminds me of the sun");
                    break;

                case "orange":
                    Console.WriteLine("I like orange juice!");
                    break;

                default:
                    Console.WriteLine("Never heard of that color, what does it look like?");
                    break;
            }



            try
            {
                Random random = new Random();
                if (random.Next(1,100) % 2 == 0)
                {
                    //throw new NullReferenceException();
                    Console.WriteLine("World is bad");
                }
                else if (random.Next(1, 100) % 3 == 0)
                {
                    //throw new Exception();
                    Console.WriteLine("World is okay");
                }
                else
                {
                    Console.WriteLine("The world is good");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //return exitCode;
                
            }
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            finally
            {
                Console.WriteLine("Henlooooo");
            }
            
            DoSomethingElse();

            //return exitCode;
        }



        private static void DoSomething()
        {
            Console.WriteLine("I am doing something!");
           //return 15;
        }

        private static void DoSomethingElse()
        {
            Console.WriteLine("I am doing something else!");            
        }
        //private static void Main()
        //{
        //    Console.WriteLine("Blah Blah Blah");
        //}

    }
}
