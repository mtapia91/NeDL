using System;
namespace tier1_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<BaseMembership> baseMembershipList = new List<BaseMembership>();

            baseMembershipList.Add(new Regular(75872599, "Alison Bauer-1", "test@test.com-1", "Regular Membership-1", 99, 212, .2));      //start of test data
            baseMembershipList.Add(new Regular(24032294, "Litzy Reily-1", "test@test.com-1", "Regular Membership-1", 99, 382, .2 ));

            baseMembershipList.Add(new Executive(76240706, "Whitney Kelly-2", "test@test.com-2", "Executive Membership-2", 149, 197, .2, .4));
            baseMembershipList.Add(new Executive(66107815, "Micah McCann-2", "test@test.com-2", "Executive Membership-2", 149, 424, .2, .4));

            baseMembershipList.Add(new NonProfit(78004179, "Kiley Gardner-3", "test@test.com-3", "NonProfit Membership-3", 99, 212, .8, true));
            baseMembershipList.Add(new NonProfit(30237552, "Araceli Dunn-3", "test@test.com-3", "NonProfit Membership-3", 99, 212, .4, false));
            
            baseMembershipList.Add(new Corporate(86840525, "Adelyn Sparks-4", "test@test.com-4", "Corporate Membership-4", 99, 212, .3));
            baseMembershipList.Add(new Corporate(95974816, "Dwayne King-4", "test@test.com-4", "Corporate Membership-4", 99, 212, .3));

            //===============================================================================================================================
            //===============================================================================================================================            
            
            bool userChoice;
            char userChoiceChar;
            /* bool userChoiceA;
            char userChoiceCharA;
            bool userChoiceT;
            char userChoiceCharT; */
           
        do
        {
            //admin or transaction menu?
           do
            {
                Console.WriteLine("Please select one of the following options:\n'A' for Administrative menu\n'T' for Transaction menu or\n'Q' to Quit the program");

                userChoiceChar = Convert.ToChar(Console.ReadLine());

                userChoice = (userChoiceChar=='A' || userChoiceChar=='a' ||
                              userChoiceChar=='T' || userChoiceChar=='t' ||
                              userChoiceChar=='Q' || userChoiceChar=='q');

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } 
            while (!userChoice);
            
            //administrative menu selection/options
            if (userChoiceChar=='A' || userChoiceChar=='a')
            {
                //administrative menu
                do
                {
                    Console.WriteLine("C: Create a unique new membership. ");
                    Console.WriteLine("R: Read all memberships on list. ");
                    Console.WriteLine("U: Update an existing membership (will require membership ID). ");
                    Console.WriteLine("D: Delete an existing membership (will require membership ID). " );

                    userChoiceChar = Convert.ToChar(Console.ReadLine());

                    userChoice = (userChoiceChar=='C' || userChoiceChar=='c' ||
                                  userChoiceChar=='R' || userChoiceChar=='r' ||
                                  userChoiceChar=='U' || userChoiceChar=='u' ||
                                  userChoiceChar=='D' || userChoiceChar=='d');
                    
                    //user selection validation
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } 
                while (!userChoice);
            }

                //CREATE selection from administrative menu
                if (userChoiceChar=='C' || userChoiceChar=='c')
                {
                    Console.WriteLine("Please enter the first & last name of the member you'd like to create: ");
                    string newMemberName = Console.ReadLine();
                    
                    // random account # generator
                    Random generator = new Random();
                    string membershipID = generator.Next(0, 99999999).ToString();
                    string newMembershipID = membershipID;
                    Console.WriteLine("Your new members ID is: " + newMembershipID);        //TODO: figure out how to validate the account # doesn't already exist either before/after adding it to the list
                   
                    Console.WriteLine("Please enter email address: ");
                    string newEmailAddress = Console.ReadLine();
                    
                    Console.WriteLine("Please enter the membership type you'd like (i.e. Regular, Executive, Non-Profit, Corporate): ");
                    string newMembershipType = Console.ReadLine();

                }    
                if (userChoiceChar=='R' || userChoiceChar=='r')
                    foreach (BaseMembership aMembership in baseMembershipList)
                    {
                        Console.WriteLine(aMembership);       
                    }

                if (userChoiceChar=='U' || userChoiceChar=='u')
                
                if (userChoiceChar=='D' || userChoiceChar=='d')
                            
            //transaction menu selection/options
            if (userChoiceChar=='T' || userChoiceChar=='t')
            {
                do          //transaction menu
                {
                    Console.WriteLine("L: List all memberships & membership information. ");
                    Console.WriteLine("P: To purchase. ");
                    Console.WriteLine("T: To return. ");
                    Console.WriteLine("A: Apply cash back rewards. ");
                    //Console.WriteLine("Q: Quit the program. ");

                    //  TODO: Get a user option (valid means its on the menu)

                    userChoiceChar = Convert.ToChar(Console.ReadLine());

                    userChoice = (userChoiceChar=='L' || userChoiceChar=='l' ||
                                  userChoiceChar=='P' || userChoiceChar=='p' ||  // PURCHASE -must include member# //-PURCHASE amt. (must be > 0) //-IF member# exists, current purchase amt. is INCREASED by the purch. amt.
                                  userChoiceChar=='T' || userChoiceChar=='t' ||  // RETURN -must include member# //-RETURN amt. (must be > 0) //-IF member# exists, current purchase amt. is DECREASED by the purch. amt.
                                  userChoiceChar=='A' || userChoiceChar=='a');

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } 
                while (!userChoice);

                if (userChoiceChar=='L' || userChoiceChar=='l')
                foreach (BaseMembership aMembership in baseMembershipList)
                {
                    Console.WriteLine(aMembership);      
                }

                if (userChoiceChar=='P' || userChoiceChar=='p')
                {

                }

                if (userChoiceChar=='T' || userChoiceChar=='t')
                {
                    
                }

                if (userChoiceChar=='A' || userChoiceChar=='a')
                {

                }

            }
        }
        while (!(userChoiceChar=='Q' || userChoiceChar=='q'));
        }
    }
}