using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Folder where the file is stored, file name and the extension 
            string filepath = @"C:\projects\employeeinfo.txt";

            //defining type string 
            List<string> lines = new List<string>();

            //assigning the output and converting an array to a list
            lines = File.ReadAllLines(filepath).ToList();

            //loop through the list and print each string to the console
            foreach (string line in lines) {
                
                if (line.Contains("Faith") == true)
                {

                    Console.WriteLine(line);
                }
                else {
                    //if no string was found, print nothing
                    Console.WriteLine("");
                }
            }

            //Readline pauses the program after all statements have been executed.
            Console.ReadLine();
        }
    }
}
