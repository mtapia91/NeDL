using System;

namespace rest_rate
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Restaurants & Ratings ");

    //  Declare variables
        bool userChoice;
        int index = 0;
        string userChoiceString;
        string[] restNames = new String[25];
        string[] restRates = new String[25];
        do
        {
            //  TODO: Get a valid input
            do
            {
            // Initialize variables
            userChoice = false;

            //  TODO: Provide the user a menu of options

            Console.WriteLine("Please select an option below: ");
            Console.WriteLine("O: Open your lists of restaurants. ");
            Console.WriteLine("S: Save your lists of restaurants. ");
            Console.WriteLine("C: Add your restaurant and rating. ");
            Console.WriteLine("R: List of your restaurants and ratings. ");
            Console.WriteLine("U: Update the rating for a restaurant. ");
            Console.WriteLine("D: Delete a name from the array. ");
            Console.WriteLine("Q: Quit the program. ");

            //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="O" || userChoiceString=="o" ||
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
            
            //  TODO: If the option is L or 1 then load the text file (restaurant_ratings.txt) into the array (nameArray)
            if (userChoiceString=="O" || userChoiceString=="o")
            {
                using (StreamReader sr = File.OpenText("restaurant_ratings.txt"))
                {
                    string rName = "";
                    string rRate = "";
                    while ((rName = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(rName);
                            restNames[index] = rName;
                            rRate = sr.ReadLine();
                            Console.WriteLine(rRate);
                            restRates[index] = rRate;
                            index++;
                        }
                        Console.WriteLine("");
                }
            }
            //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                if (File.Exists("restaurant_ratings.txt"))
                {
                    File.Delete("restaurant_ratings.txt");
                }
                Console.Write("Your changes have been applied. ");
                
                using (StreamWriter fileStr = File.CreateText("restaurant_ratings.txt"))
                {
                    for (index = 0; index < 25; index++) 
                    {          
                        if (!(restNames[index]==null))
                        {   
                            fileStr.WriteLine(restNames[index]);                       
                            fileStr.WriteLine(restRates[index]);
                        }
                    }
                }
             
            }
            
            //  TODO: Else if the option is a C  or c then add a name to the array (if there's room)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
/*                Console.WriteLine("Please provide restaurant name and rating. ");
                string newName = Console.ReadLine();
                bool found = false;
                Console.WriteLine(""); //entering a blank to give some space
                //indexto addit to the array
                for (index = 0; index < 25; index++)
                {
                    if(((restNamesRates[index]) == "") && (found == false))  //if a blank spot is found
                    {
                        restNamesRates[index] = newName; //adding name at blank spot found
                        found = true; 
                        Console.WriteLine("Here is a list of your restaurants and ratings: " +restNamesRates[index]);
                    }
                }    */           
            }

            //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                
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
        } 
        while (!(userChoiceString=="Q") && !(userChoiceString=="q")); //ends do/while loop on line 13
     }// ends main
  } // ends program 
} // ends namespace
                