using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace FileHandling
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //Directory
            //File



            string path = @"C:\Users\Safal\Desktop\Practice\ForFileHandling";

            string[] directorys = Directory.GetDirectories(path);

            foreach(string dir in directorys)
            {
                WriteLine(dir, "*", SearchOption.AllDirectories);
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                WriteLine(file, "*", SearchOption.AllDirectories);
                WriteLine(Path.GetFileName(file));
                WriteLine(Path.GetFileNameWithoutExtension(file));
            }

            //Reading from file

            string filePath = @"C:\Users\Safal\Desktop\Practice\DataAccess\Data.txt";


            //if (File.Exists(filePath))
            //{
            //    //List<string> lines = File.ReadAllLines(filePath).ToList();

            //    //foreach (string line in lines)
            //    //{
            //    //    WriteLine(line);
            //    //}

            //    ////Writing to file
            //    //lines.Add("Bibesh, Shrestha, Bafal");
            //    //lines.Add("Bidur, Dai, Ramkot");
            //    //lines.Add("Suraj, Bohara, Kalanki");

            //    //File.WriteAllLines(filePath, lines);


            //    //Read Op

            //    List<Person> personList = new List<Person>(); //Complex Type

            //    List<string> _lines = File.ReadAllLines(filePath).ToList();

            //    WriteLine("Read from the text file");

            //    foreach(var l in _lines)
            //    {
            //        string[] items = l.Split(',');

            //        Person newPerson = new Person();
            //        newPerson.FirstName = items[0];
            //        newPerson.LastName = items[1];
            //        newPerson.Address = items[2];

            //        personList.Add(newPerson);
            //    }


            //    foreach(var p in personList)
            //    {
            //        WriteLine($"{p.FirstName} {p.LastName} {p.Address}");
            //    }


            //    //Write

            //    personList.Add(new Person { FirstName = "Sushmita", LastName = "Ghimire", Address = "Macchapokhari" });

            //    List<string> result = new List<string>();

            //    foreach(var p in personList)
            //    {
            //        result.Add($"{p.FirstName}, {p.LastName}, {p.Address}");
            //    }

            //    WriteLine("Writing to file");
            //    File.WriteAllLines(filePath, result);

            //    WriteLine("Items added Success!");








            //}
            //else
            //{
            //    File.CreateText(filePath);               
            //}


            string filePathHtml = @"C:\Users\Safal\Desktop\Practice\DataAccess\Index.html";
            string templateCopy = @"C:\Users\Safal\Desktop\Practice\DataAccess\IndexCopy.html";

            string template = filePathHtml;

            //Streamreader vs TextReader -> Google It
            if (File.Exists(template))
            {
                StreamReader sr = new StreamReader(template); //->template read

                string content = sr.ReadToEnd();
                sr.Close();

                StreamWriter sw = new StreamWriter(templateCopy);

                Person p = new Person();
                p.FirstName = "Manisha";
                p.LastName = "Pandey";
                p.Address = "Kalanki";

                content = content.Replace("{firstName}", p.FirstName)
                    .Replace("{lastName}", p.LastName)
                    .Replace("{address}", p.Address);

                sw.Write(content);
                sw.Close();

            }
            else
            {
                WriteLine("File not found.");
            }









        }
    }
}
