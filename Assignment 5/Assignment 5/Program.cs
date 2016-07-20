using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Nick Morin
 * Description: Assignment 5 - File I/O and Exception Handling
 * Last Modified: 2016-07-20
 */


namespace Assignment_5
{

    class Program
    {
        static void Main(string[] args)
        {
            
            string menuSwitch; //controls the do-while loop and the switch
            string fileName; //defines the file name that will be entered
            string line; //defines each line of the file
            List<string> Students = new List<string> { };

            //Begins the do-while loop that runs the program
        Start:
            Console.Clear();
            do
                //Prompts the user to select "1" or "2" and reads from console
            {Console.Write("1 = Display Grades\n2 = Exit\nEnter a number to select an option: ");
            menuSwitch=( Console.ReadLine());
                
                //switch reads the menuSwitch variable
                switch (menuSwitch)
                {
                    //if "1" is entered, switch begins the main body of program and prompts user to enter a file name
                    case "1":
                        Console.Clear();
                        Console.Write("Enter name of file: ");
                        fileName = Console.ReadLine();
                        try
                        {
                            //if file is found, adds each line of the file as a string to "Students" List
                            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                            
                            while ((line = file.ReadLine()) != null)
                            {
                                Students.Add(line);
                                
                               
                            }

                            file.Close();
                            
                            //displays the contents of "Students" List

                            Console.Clear();
                            foreach (string student in Students)
                                System.Console.WriteLine(student);
                            Console.Write("\nPress any key to return to menu");

                            System.Console.ReadKey();
                            goto Start;
                            
                        }
                        //if file is not found, displays error and sends user to menu
                        catch (System.IO.FileNotFoundException)
                        {
                            Console.Clear();
                            Console.Write("Error: File not Found - Press any key to return to menu");
                            Console.ReadKey();
                            goto Start;

                        }

                  /*default if anything but "1" is entered into the console at start of program 
                   * Clears the Students list and the Console, displays an error message and returns user to start
                   */      
                    default:
                        Students.Clear();
                        Console.Clear();
                        Console.WriteLine("Error - Enter 1 or 2 to select an option\n");

                        break;                        
                }

                //Entering 2 changes menuSwitch variable to 2, breaking the do-while loop and closing console
            } while (menuSwitch != "2");




        }
    }
}
