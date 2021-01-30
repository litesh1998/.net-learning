﻿#nullable enable
using System;

namespace NullHandelling
{

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City= string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}
