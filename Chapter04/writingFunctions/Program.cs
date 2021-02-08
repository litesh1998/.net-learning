using System;
using static System.Console;

namespace writingFunctions
{
    class Program
    {
        static void PrintTable(byte number){
            WriteLine($"Printing The Table of {number}");
            for( int i=1; i<=10; i++){
                WriteLine($"{number}  X  {i,2} = {number*i,2}");
            }
        }

        static void RunTable(){
            bool IsNumber;

            do {

                WriteLine("Enter a Number between 0 and 255");
                IsNumber = byte.TryParse(ReadLine(), out byte number);

                if(IsNumber){
                    PrintTable(number);
                }
                else{
                    WriteLine("The Number is not between 0 and 255");
                }
                
            }
            while(IsNumber);
        }
        static void Main(string[] args)
        {
            RunTable();
        }
    }
}
