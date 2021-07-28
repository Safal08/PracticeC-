using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Linq
{
    public class Program
    {

        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }


            //static void Main(string[] args)
            //{
            //    Student.GetName("Safal");

            //    try
            //    {
            //        Console.WriteLine("Enter first number."); //CLR is creating an instance and throwing the instance
            //        int x = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter Second number.");
            //        int y = int.Parse(Console.ReadLine());
            //        int z = x / y;
            //        Console.WriteLine("The result is {0}", z);
            //    }
            //    catch (DivideByZeroException ex1)
            //    {

            //        //throw ex;
            //        Console.WriteLine(ex1.Message);
            //    }

            //    catch (FormatException ex2)
            //    {

            //        //throw ex;
            //        Console.WriteLine("Input is not numeric value so can't parse.");
            //    }

            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Hello I am finally block.");
            //    }


            //    Console.WriteLine("End of the program.");






            //    int[] array = { 2, 3, 4, 10, 12, 14, 18, 19, 20, 21, 24, 25 };

            //    int count = 0;

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 2 == 0)
            //            count++;
            //    }

            //    WriteLine("The number of even number is {0}", count);

            //    int[] array1 = new int[count];

            //    int j = 0;

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 2 == 0)
            //        {
            //            array1[j] = array[i];
            //            j++;

            //        }
            //    }

            //    for (int i = 0; i < count; i++)
            //    {
            //        WriteLine("Even number {0} is {1}", i + 1, array1[i]);
            //    }

            //    What if we can write a query in a Array? It will minimize the complexity we are facing.

            //    LINQ--CODe start

            //    Implicitly define local variable


            //    var array2 = from i in array where i % 2 > 0 orderby i ascending select i; //SQL Like syntax

            //    foreach (int k in array2)
            //    {
            //        WriteLine(k + " ");
            //    }



            //    Jati pani collections, collection generics haru esbata inherit vha hunxa
            //    IEnumerable<Student> result = from s in Student.GetAllStudents()
            //                                  where s.Address == "Thankot"
            //                                  select s;

            //    //Lamda expression

            //    IEnumerable<Student> results = Student.GetAllStudents().Where(x => x.Address == "Thankot");

            //    foreach (var s in results)
            //    {
            //        WriteLine(s.Name);
            //    }




            //}
        }
    }
}
