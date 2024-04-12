using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System;

namespace Hello_World
{
    internal class Program
    {
        //Hoang Khoi Gia Nguyen
        //Computer Programming 120
        //04/04/2024

        static void Main(string[] args)
        {
            Practice();
            StringExample();
            Console.WriteLine();

            Console.Write("Enter name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Display Name:" + userName);

            Console.Write("Current Date:");
            string userDate = Console.ReadLine();

            Console.WriteLine($"Input Date: {userDate}");


            Console.Write("Current Class:");
            string userClass = Console.ReadLine();

            Console.WriteLine($"Class in progress: {userClass}");

            Console.WriteLine();
            Console.WriteLine("Information:");
            Console.WriteLine($" {userName}");
            Console.WriteLine($" {userDate}");
            Console.WriteLine($" {userClass}");



        }

        public static void StringExample() 
        {
         string firstName = "Hoang Khoi";
         string lastName = "Nguyen";
         string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

         string position;
         position = "Student";
            Console.WriteLine(position);


            // Lecture 1
            // What kind of error does a red squiggly line in your code represent?
            // Ans: Compile Time Error.

            // What is the difference between Console.Write() and Console.WriteLine()?
            // Ans: Console.WriteLine() go to a new line while Console.Write() does not.

            // What symbol is used to tell our code something is a string?
            // Ans: Double Quotation

            // What service do we use to save our code online?
            // Ans: Github

            // When you see { and }, this indicates a bunch of code is grouped together. This is called a?
            // Ans: Code Block
        }

        public static void Practice()
        {
            Console.WriteLine("Hoang Khoi Gia Nguyen");
            Console.WriteLine("Progamming 120");
            Console.WriteLine("I listen to music and play video games to relax.");
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            // Lecture 2
            // 1. What does it mean to declare and initialize?
            // Declare means creating a variable by giving a name and type. Initialize assigns a value to a variable when it is created.

            // 2.What does it mean to concatenate ?
            // Adding two strings together to create a longer one.

            // 3.What is a "string" type consist of(ex.numbers, letters, etc... )?
            // The "string" type consist of any kind of character, be it letters, numbers or unique characters.

            // 4.Console.ReadLine() returns what TYPE ?
            // Console.ReadLine() always return a "string" TYPE.

            // 5.What happens if you try to assignment a value to a variable before it has been declared?
            // It will cause an error saying that the variable is not yet declared.
        }

    }
}
