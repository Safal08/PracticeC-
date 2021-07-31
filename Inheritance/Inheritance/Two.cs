using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Inheritance
{

    
   // 3) Polymorphism - One name many form
   // Sure question
   // i) Method Overloading vs Method Overiding
   //ii) Method Overiding vs Method Hiding
    public class Two 
    {
        //Method Overloading -> signature chai farak hunu parxa - Defining multiple method with same name and with different signature
        //Method Overiding -> Defining multiple method with same name and same signature

        public void GetParent()//Yeslai hide gariraxu
        {
            WriteLine("I am Get Parent");
        }
        public virtual void ShowParent() //Overidable  //Yeslai overirde gariraxu
        {
            WriteLine("I am show Parent");
        }

       
        static void Main(string [] args)
        {          
            
            Three th = new Three();
            th.GetParent();
            th.ShowParent();
            WriteLine("*********************************");

            Two t2 = new Three(); //Object k ko banairaxam -> Parent 
            t2.GetParent();

            t2.ShowParent();

        }
    }

    public class Three: Two
    {
        public new void GetParent() // new is for hiding
        {
            WriteLine("I am Get Parent from Child");
        }
        public override void ShowParent() //override is for override
        {
            WriteLine("I am show Parent Child");
        }
    }
}

//In method hiding a base class reference variable pointing to a child class objet, it will invoke the hidden method in the parent class.
//In method hiding we use new keyword

//In method overriding a base class reference variable pointing to a child class objet, it will invoke the overriden method in the child class.
//In method overriding we use virtaul and overide keyword