using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            Console.Write("What is your first name?");
            string firstName = Console.Readline();

            Console.Write("What is your last name?");
            string lastName = Console.Readline();

            // TODO: Call a method called FullName that returns their full name.
           Console.WriteLine(FullName);
            
            // TODO: Output their full name.

            Console.ReadLine();
        }

        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
        static void FullName(string firstName, string lastName);
        {
           string message = (firstName + lastName); 

            return String.Concat(message);

        }
    }   
}