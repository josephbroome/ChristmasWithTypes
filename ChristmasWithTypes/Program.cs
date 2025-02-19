﻿using System;

namespace ChristmasWithTypes
{
    class Program
    {
        public static object relativename { get; private set; }

        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.day.Friday;

            //TODO set Santa's name to Kris Kringle
            xmas.Santa = "CRAMPUS";

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{"xbox", "my little pony", "weapons of mass destruction" }; 

            //TODO Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");

            xmas.relativename = new string[4]{ "Uncle Michael", "Uncle Howard", "Auntie Gwen", "Uncle Greg" };

            foreach (var present in xmas.relativename)
            {
                Console.WriteLine($"   {relativename}");
            }
        }
    }
}
