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
    string[] nameArray = new String[11];
        do
        {
            //  TODO: Get a valid input
            do
            {
                // Initialize variables
                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What's your deal? ");
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
            
            //  TODO: If the option is L or 1 then load the text file (names.txt) into the array (nameArray)
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
                    }
                    Console.WriteLine("");
            }
            }

            //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
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
                    if((NameArray[index])) == "") && found == false)
                    {
                        nameArray[index] = newName;
                        found = true;

                        Console.WriteLine(nameArray[index]));
                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is Extra");
                    sw.WriteLine("Text");
                }	

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }


            }

            //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                for (int index = 0; index < 11; index++)
                {
                    Console.WriteLine(nameArray[index]);
                }
            }

            //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

            //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            }

            // TODO: Else is a Q or q then the program ends

            else
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    } // ends main
  } // ends program 
} // ends namespace


/* next to tackle; delete name from array 
*/
                