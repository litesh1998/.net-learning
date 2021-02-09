using System;
using static System.Console;
using Packt.Shared;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var bob = new Person();
            // WriteLine(bob.ToString());
            bob.Name="Bob Smith";
            bob.DateOfBirth= new DateTime(1965, 12, 21);
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );
        }
    }
}
