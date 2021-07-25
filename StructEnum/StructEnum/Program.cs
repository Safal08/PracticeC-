using System;
using static System.Console;
using System.IO;

namespace StructEnum
{
    //Class -- Non abstract method
    //Abstract Class  -- Non abstract method || Abstract method
    //Interface -- Abstract Method it does not contain implementation of method

    //Multiple inheritance is possible when we are ihnheriting interface

   
    public class Program : IStudent , IStudent1
    {     
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Difference(53,44);
            p.Sum(34,76);

            p.Print();
           
        }


        public void Difference(int a, int b)
        {
            WriteLine("Diffrence is {0} ", a-b);
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public int Sum(int x, int y)
        {
            WriteLine("Sum  is {0}" , x+y);
            return 0;
        }

        void IStudent.Sum(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
