using System;

namespace Program
{
    class Person
    {
        public string? name;
        public string? lastName;

        public void RenderText(string firstName, string lastName)
        {
            this.name = firstName;
            this.lastName = lastName;

            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
        }

    }

    class User : Person
    {

        public User()
        {
            Console.WriteLine("Hello Usere..");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            User user = new();
            user.RenderText("Ryan", "James");
        }
    }

}
