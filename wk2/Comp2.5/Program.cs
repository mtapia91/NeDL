using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    //  Declare variables
    bool userChoice;
    string userChoiceString;
    string[] nameArray = new String[10];
        do
        {
            //  TODO: Get a valid input
            do
            {
                // Initialize variables
                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("Choose your poison: ");
                Console.WriteLine("L: Load the data file into an array. ");
                Console.WriteLine("S: Store the array to your data file. ");
                Console.WriteLine("C: Add a name to the array. ");
                Console.WriteLine("R: Read a name from the array. ");
                Console.WriteLine("U: Update a name in the array. ");
                Console.WriteLine("D: Delete a name from the array. ");
                Console.WriteLine("Q: Quit the program. ");

            //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                                userChoiceString=="S" || userChoiceString=="s" ||
                                userChoiceString=="C" || userChoiceString=="c" ||
                                userChoiceString=="R" || userChoiceString=="r" ||
                                userChoiceString=="U" || userChoiceString=="u" ||
                                userChoiceString=="D" || userChoiceString=="d" ||
                                userChoiceString=="Q" || userChoiceString=="q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } 
            while (!userChoice);
            
            //  TODO: If the option is L or l then load the text file (names.txt) into the array (nameArray)
            if (userChoiceString=="L" || userChoiceString=="l")
            {
                int index = 0;  //index for my array
                using (StreamReader sr = File.OpenText("names.txt"))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file names.txt : ");
                    while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            nameArray[index] = s;
                            index++;
                        }
                        Console.WriteLine("");
                }
            }
// some weird comment
//test test test test 
            //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                 if (File.Exists("names.txt"))
                {
                    File.Delete("names.txt");
                }
                Console.Write("Changes to your array have been updated to your text file. ");
                
                using (StreamWriter fileStr = File.CreateText("names.txt"))
                {              
                    int index = 0;
                    fileStr.WriteLine(nameArray[index]);
                       
                }
                using (StreamReader sr = File.OpenText("names.txt"))
                {
                    string s = "";
                    int index = 0;
                    while ((s = sr.ReadLine()) != null)
                        {
                            nameArray[index]= s;
                            index++;
                        }
                }             
            }
            
            //  TODO: Else if the option is a C  or c then add a name to the array (if there's room)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                int index = 0;
                Console.WriteLine("What name do you want to add?");
                string newName = Console.ReadLine();
                bool found = false;
                Console.WriteLine(""); //entering a blank to give some space
                //indexto addit to the array
                for (index = 0; index <10; index++)
                {
                    if(((nameArray[index]) == "") && (found == false))  //if a blank spot is found
                    {
                        nameArray[index] = newName; //adding name at blank spot found
                        found = true; 

                        Console.WriteLine(nameArray[index]);
                    }
                }              
            }

            //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(nameArray[index]);
                }
            }


        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    } // ends main
  } // ends program 
} // ends namespace


/* next to tackle; delete name from array 
*/
                