using System;

namespace Delegates
{    
    
    
    public class Program
    {
        int? a = null; //Value type lai nullable banauna ? use garxam

        string aa = null;
        //int -> type safe vayo tara int matra rakhna pryo
        //object -> type safe vako xaina tara hamle j rakhe ni hunxa
        //Generic -> type safe + jun value rakhe ni paune
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
            
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            bool result = p.Compare<string>("Hello","Hello");

            Console.WriteLine("The sum is {0}", result);

        }
    }
}
