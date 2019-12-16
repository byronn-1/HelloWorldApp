using System;
using System.Collections.Generic;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //for(int X = 1; X <= 5; X++)
            //{
            
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine("Hello World " + i);
            //    }
            //    for (int i = 10; i >= 1; i--)
            //    {
            //        Console.WriteLine("Hello World " + i);
            //    }
            //}

            //for(int x = 1; x < 1000; x++)
            //{
            //    Console.WriteLine("                  I LOVE SAM");
            //    Console.WriteLine("MERRY CHRISTMAS!");
            //}

            //var studentGrades = new int[] { 80, 77, 86, 90, 91, 74, 93, 47, 68, 85, };

            //for (var i = 0; i <= studentGrades.Length; i++)
            //{
            //    Console.WriteLine(studentGrades[i]);
            //}

            //    var studentGrades = new int[] { 80, 77, 86, 90, 91, 74, 93, 47, 68, 85, };

            //    foreach(var student in studentGrades)
            //    {
            //        Console.WriteLine(student);
            //    }
            //    WriteTryAgain();

            //}

            // static void WriteTryAgain()
            //{
            //    Console.WriteLine("You didn't write anything, please try again.");

            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;
            while (adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
                }
        }
        class Student
        {
            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            public int Phone;
        }

    }
}
