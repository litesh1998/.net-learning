using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = new string[4];
            names[0] ="Kaite";
            names[1] ="Ammediel";
            names[2]="Chole";
            names[3]="Maze";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
