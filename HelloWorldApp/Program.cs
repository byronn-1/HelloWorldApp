using System;
using System.Collections.Generic;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Import()
            {
                var importedStudent = new Student("Jenny", 86, "birthday", "address");
                Console.WriteLine(importedStudent.Name);
            }

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

            var students = new List<Student>();

            //var studentNames = new List<string>();
            //var studentGrades = new List<int>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");

                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));

                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                newStudent.Address = Util.Console.Ask("Student Address: ");

                //Console.Write("Student Phone Number: ");
                //newStudent.SetPhone( Console.ReadLine());

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3} ", student.Name, student.Grade, student.Birthday, student.Address);
            }
        }
        class Student
        {
            static public int Count = 0 ;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            //private string phone;

            //public string Phone
            //{
            //    set { phone = value; }

            //}
            //public void SetPhone(string phoneNumber)
            //{
            //    phone = phoneNumber;
            //}
            public Student()
            {

            }
            public Student(string name, int grade, string birthday, string address)
            {
                Console.WriteLine("constructor");
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Address = address;
            }
        }

    }
}
