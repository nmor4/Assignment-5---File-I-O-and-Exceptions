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
           
            //
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
                            int counter = 0;
                            while ((line = file.ReadLine()) != null)
                            {

                                System.Console.WriteLine(line);
                                counter++;
                            }

                            file.Close();
                            System.Console.WriteLine("There were {0} lines.", counter);

                            System.Console.ReadKey();

                            
                        }
                        catch (System.IO.FileNotFoundException)
                        {
                            Console.Clear();
                            Console.WriteLine("Error: File not Found - Press any key to return to file selection");
                            Console.ReadKey();
                            goto case "1";

                        }

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error - Enter 1 or 2 to select an option");

                        break;                        
                }
            } while (menuSwitch != "2");




        }
    }
}
