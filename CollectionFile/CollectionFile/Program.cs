using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace CollectionFile
{
    
    //Collections and Collections.Generic both are different
    public class Program
    {
        public class Student
        {
            public int Id{ get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                Id = 101,
                Name = "Bipin",
                Address = "Kritipur"

            };
            Student s2 = new Student()
            {
                Id = 102,
                Name = "Bipana",
                Address = "Kalanki"

            };
            Student s3 = new Student()
            {
                Id = 103,
                Name = "Bidur",
                Address = "Ramkot"

            };

            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            studentDictionary.Add(s1.Id, s1);
            studentDictionary.Add(s2.Id, s2);
            studentDictionary.Add(s3.Id, s3);

            foreach(KeyValuePair<int,Student> studentVP in studentDictionary)
            {
                WriteLine("Key is {0}", studentVP.Key);

                //int
                Student st = studentVP.Value; //Complex
                WriteLine("ID = {0}, Name ={1}, Address = {2}", st.Id, st.Name, st.Address);

            }


         
        }
    }
}
