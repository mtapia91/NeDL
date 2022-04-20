using System;

namespace rest_rate
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("\n    RESTAURANTS & RATINGS ");
        Console.Write("\n------------------------------");

    //  Declare variables
        bool userChoice;
        int index = 0;
        string userChoiceString;
        string[] restNames = new String[25];
        string[] restRates = new String[25];
        string rName = "";
        string rRate = "";
        do
        {
            //  TODO: Get a valid input
            do
            {
            // Initialize variables
            userChoice = false;

            //  TODO: Provide the user a menu of options

            Console.WriteLine("\nPLEASE SELECT AN OPTION BELOW: \n");
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
                    Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                }
            } 
            while (!userChoice);
            
            //  TODO: If the option is L or 1 then load the text file (restaurant_ratings.txt) into the array (nameArray)
            if (userChoiceString=="O" || userChoiceString=="o")
            {
                using (StreamReader sr = File.OpenText("restaurant_ratings.txt"))
                {
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
                Console.Write("          YOUR CHANGES HAVE BEEN APPLIED. ");
                Console.Write("\n-------------------------------------------------\n");
                
                using (StreamWriter fileStr = File.CreateText("restaurant_ratings.txt"))
                {
                    for (index = 0; index < 25; index++) 
                    {          
                        if (!(restNames[index]==null)) //kind of like reversed engineered; if return is null, ! will make statement true
                                                       //so the block of code below can be ran
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
                string newName;
                bool found = false;

                for (index = 0; index < 25; index++) //index to add it to the array
                {

                    if(((restNames[index]) == null) && (found == false))  //if a blank spot is found the code within {} below will be executed
                    {
                        Console.WriteLine("PLEASE ENTER NEW RESTAURANT NAME: \n");
                        rName = Console.ReadLine();
                        restNames[index] = rName; //adding name at blank spot found
                        Console.WriteLine("PLEASE ENTER NEW RESTAURANT RATING: \n");
                        rRate = Console.ReadLine();
                        restRates[index] = rRate; //adding name at blank spot found
                        found = true; 
                    }
                }               
            }

            //  TODO: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                if (File.Exists("restaurant_ratings.txt")) 
                {
                    // Store each line in array of strings
                    string[] lines = File.ReadAllLines("restaurant_ratings.txt");
        
                    foreach(string ln in lines)
                    Console.WriteLine(ln);
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
        } 
        while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
     }// ends main
  } // ends program 
} // ends namespace


/*Work left: Need to get Update and Delete functions working. And validate all input.*/
