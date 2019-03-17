using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            Console.Write("What is your first name?");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name?");
            string lastName = Console.ReadLine();

            // TODO: Call a method called FullName that returns their full name.
            Console.WriteLine(FullName(firstName, lastName));
            Console.ReadLine();            
            // TODO: Output their full name.            
        }
        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
        public static string FullName( string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        
    }   
}