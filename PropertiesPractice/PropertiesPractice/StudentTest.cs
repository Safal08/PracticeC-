using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PropertiesPractice
{
    public class StudentTest
    {
        //Array ko syntax
        //In C# Java ma global variable vanne nai hunna


        static void Main(string [] args)
        {
            Student stu = new Student(10, "Bipin", "Thankot", 456.89);         

            WriteLine("The student Id is {0}", stu[0]);            
            WriteLine("The student Name is {0}", stu[1]);
            WriteLine("The student Address= is {0}", stu[2]);
            WriteLine("The student Marks is {0}", stu[3]);
            ReadLine();

            stu[0] = 19;
            stu[1] = "Bibesh";
            stu[2] = "Bafal";
            stu[3] = 5678.8;

            WriteLine("The student Id is {0}", stu[0]);
            WriteLine("The student Name is {0}", stu[1]);
            WriteLine("The student Address= is {0}", stu[2]);
            WriteLine("The student Marks is {0}", stu[3]);
        }
    }
}
