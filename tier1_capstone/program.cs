using System;
namespace tier1_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userChoice;
            char userChoiceChar;
            List<MembershipInfo> membershipInfoList = new List<MembershipInfo>(); 
            do      //admin or member menu?
            {
                //  TODO: Provide the user a menu of options

                Console.WriteLine("Are you a ValueCo account administrator or ValueCo member? ");
                Console.WriteLine("L: Load the data file into an array. ");
                Console.WriteLine("S: Store the array to your data file. ");
                Console.WriteLine("C: Add a name to the array. ");
                Console.WriteLine("R: Read a name from the array. ");
                Console.WriteLine("U: Update a name in the array. ");
                Console.WriteLine("D: Delete a name from the array. ");
                Console.WriteLine("Q: Quit the program. ");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceChar = Convert.ToChar(Console.ReadLine());

                userChoice = (userChoiceChar=='L' || userChoiceChar=='l' ||
                                userChoiceChar=='S' || userChoiceChar=='s' ||
                                userChoiceChar=='C' || userChoiceChar=='c' ||
                                userChoiceChar=='R' || userChoiceChar=='r' ||
                                userChoiceChar=='U' || userChoiceChar=='u' ||
                                userChoiceChar=='D' || userChoiceChar=='d' ||
                                userChoiceChar=='Q' || userChoiceChar=='q');

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } 
                while (!userChoice);


            do      //admin menu
            {
                //  TODO: Provide the user a menu of options

                Console.WriteLine("Are you a ValueCo account administrator or ValueCo member? ");
                Console.WriteLine("L: Load the data file into an array. ");
                Console.WriteLine("S: Store the array to your data file. ");
                Console.WriteLine("C: Add a name to the array. ");
                Console.WriteLine("R: Read a name from the array. ");
                Console.WriteLine("U: Update a name in the array. ");
                Console.WriteLine("D: Delete a name from the array. ");
                Console.WriteLine("Q: Quit the program. ");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceChar = Convert.ToChar(Console.ReadLine());

                userChoice = (userChoiceChar=='L' || userChoiceChar=='l' ||
                                userChoiceChar=='S' || userChoiceChar=='s' ||
                                userChoiceChar=='C' || userChoiceChar=='c' ||
                                userChoiceChar=='R' || userChoiceChar=='r' ||
                                userChoiceChar=='U' || userChoiceChar=='u' ||
                                userChoiceChar=='D' || userChoiceChar=='d' ||
                                userChoiceChar=='Q' || userChoiceChar=='q');

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } 
                while (!userChoice)
        }
    }
}


/*================   Will implement these at some point   ================

string membershipId = String.Format("32{0}", r.ToString("D6"));
    //test data
    {
    membershipInfoList.Add(new MembershipInfo(6548974, "Test Test", "test@test.com", "regular", 99, 212));
        

    foreach (MembershipInfo aMembership in membershipInfoList)
    {
        Console.WriteLine(aMembership);
    }  */