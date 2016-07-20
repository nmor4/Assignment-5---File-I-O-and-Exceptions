using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Nick Morin
 * Description: Assignment 5 - File I/O and Exception Handling
 * Last Modified:
 */


namespace Assignment_5
{

    class Program
    {
        static void Main(string[] args)
        {
            //This string controls the do-while loop as well as the switch function
            string menuSwitch;
            string fileName;
            string line;
            List<string> Students = new List<string> { };

        Start:
            Console.Clear();
            do
            {Console.Write("1 = Display Grades\n2 = Exit\nEnter a number to select an option: ");
            menuSwitch=( Console.ReadLine());
                
                switch (menuSwitch)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter name of file: ");
                        fileName = Console.ReadLine();
                        try
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                            
                            while ((line = file.ReadLine()) != null)
                            {
                                Students.Add(line);
                                
                               
                            }

                            file.Close();
                            Console.Clear();
                            foreach (string student in Students)
                                System.Console.WriteLine(student);
                            Console.WriteLine("\nPress any key to return to menu");

                            System.Console.ReadKey();
                            goto Start;
                            
                        }
                        catch (System.IO.FileNotFoundException)
                        {
                            Console.Clear();
                            Console.WriteLine("Error: File not Found - Press any key to return to menu");
                            Console.ReadKey();
                            goto Start;

                        }

                        
                    default:
                        Students.Clear();
                        Console.Clear();
                        Console.WriteLine("Error - Enter 1 or 2 to select an option\n");

                        break;                        
                }
            } while (menuSwitch != "2");




        }
    }
}
