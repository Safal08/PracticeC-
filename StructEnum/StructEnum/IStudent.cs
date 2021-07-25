using System;
using System.Collections.Generic;
using System.Text;

namespace StructEnum
{
    public abstract class Studenttt
    {
        //We can't create fields in interface
        int i;
        string name;
        public abstract void Print();
        public abstract void Difference(int a, int b);
        public abstract void Sum(int x, int y);

    }
    public interface IStudent
    {
        //We can't create fields in interface
        int i;
        string name;
        public void Print();
        public void Difference(int a, int b);
        public void Sum(int x, int y);
        
    }

    public interface IStudent1
    {
        public void Print();       

    }
}
