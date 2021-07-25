using System;
using static System.Console;

namespace PropertiesPractice
{
    //Indexers is also same like that properties but it provide access to value using index position
    //It behaves like a vitual array
    public class Student
    {
              
        int _Id;
        string _Name;
        string _Address;
        public double _Marks;        

        public Student(int Id, string Name, string Address, double Marks) //constuctor jaile pani class vanda paila call huncas
        {
            _Id = Id;
            _Name = Name;
            _Address = Address;
            _Marks = Marks;                   
        }

        //Creating Indexer
        //AccesssModifiers type this [int index]
        // Object reference type

        //Reference to value type -- unboxing
        //Value to reference type -- boxing

        public object this [int i]
        {
            //Get
            get
            {
                if (i == 0)
                    return _Id;
                else if (i == 1)
                    return _Name;
                else if (i == 2)
                    return _Address;
                else if (i == 3)
                    return _Marks;                
                return null;
            }
            //Set
            set {
                if (i == 0)
                    _Id = (int)value;
                else if (i == 1)
                   _Name = (string) value;
                else if (i == 2)
                   _Address = (string)value;
                else if (i == 3)
                     _Marks = (double)value;                
            }
        }

    }

   
}
