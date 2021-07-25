using System;
using static System.Console;

namespace Inheritance
{
    //Rule
    //1) We can't initialize parent classes variable by using the child class instance to make it as a reference -> a pointer to an instance
    //2) Constructor of parent class must be accesscible to child class, if not there will be no inheritance
    //3) If there is parameter in constructor, child classs conscructor cannot implicitly call its parent class constructor,
    //This problem can be solved by using base keyword
    //
    public class One //Parent class or Base class
    {
        public One(int i)
        {
            WriteLine("I am class One Constructor {0}", i);
        }

        public void Method1()
        {
            WriteLine("This is Method 1.");
        }

        public void Method2()
        {
            WriteLine("This is Method 2.");
        }        
    }
}
