using System;
namespace tier1_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userChoice;
            char userChoiceChar;

            List<BaseMembership> BaseMembershipList = new List<BaseMembership>();
            
            do      //admin or transaction menu?
            {
                Console.WriteLine("Please enter 'A' to access the administrative menu or 'T' for the transaction menu? ");

                userChoiceChar = Convert.ToChar(Console.ReadLine());

                userChoice = (userChoiceChar=='A' || userChoiceChar=='a' ||
                              userChoiceChar=='T' || userChoiceChar=='t');

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            } 
            while (!userChoice);

            if (userChoiceChar=='A' || userChoiceChar=='a')         //administrative menu selection/options
            {
                do          //administrative menu
                {
                    Console.WriteLine("C: Create a unique new membership. ");
                    Console.WriteLine("R: Read all memberships on list. ");
                    Console.WriteLine("U: Update an existing membership (will require membership ID). ");
                    Console.WriteLine("D: Delete an existing membership (will require membership ID). " );
                    Console.WriteLine("Q: Quit the program. ");


                    userChoiceChar = Convert.ToChar(Console.ReadLine());

                    userChoice = (userChoiceChar=='C' || userChoiceChar=='c' ||
                                  userChoiceChar=='R' || userChoiceChar=='r' ||
                                  userChoiceChar=='U' || userChoiceChar=='u' ||
                                  userChoiceChar=='D' || userChoiceChar=='d' ||
                                  userChoiceChar=='Q' || userChoiceChar=='q');
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");          //user selection validation
                    }
                } 
                while (!userChoice);
            }

            //Create selection from administrative menu
            if (userChoiceChar=='C' || userChoiceChar=='c')
            {
                Console.WriteLine("Please enter the first & last name of the member you'd like to create: ");
                string newMemberName = Console.ReadLine();
                
                // random account # generator
                Random generator = new Random();
                String membershipID = generator.Next(0, 99999999).ToString();
                String newMembershipID = membershipID;
                Console.WriteLine("Your new members ID is: " + newMembershipID);        //TODO: figure out how to validate the account # doesn't already exist either before/after adding it to the list
                
                Console.WriteLine("Please enter email address: ");
                string newEmailAddress = Console.ReadLine();
                
                Console.WriteLine("Please enter the membership type you'd like (i.e. Regular, Executive, Non-Profit, Corporate): ");
                string newMembershipType = Console.ReadLine();


            }    
            if (userChoiceChar=='R' || userChoiceChar=='r')



            if (userChoiceChar=='U' || userChoiceChar=='u')
            
            
            
            if (userChoiceChar=='D' || userChoiceChar=='d')
            
            
            
            if (userChoiceChar=='Q' || userChoiceChar=='q')

            
                       
            //transaction menu selection/options
            if (userChoiceChar=='T' || userChoiceChar=='t')
            {
                do          //transaction menu
                {
                    Console.WriteLine("L: List all memberships & membership information. ");
                    Console.WriteLine("P: To purchase. ");
                    Console.WriteLine("T: To return. ");
                    Console.WriteLine("A: Apply cash back rewards. ");
                    Console.WriteLine("Q: Quit the program. ");

                    //  TODO: Get a user option (valid means its on the menu)

                    userChoiceChar = Convert.ToChar(Console.ReadLine());

                    userChoice = (userChoiceChar=='L' || userChoiceChar=='l' ||
                                  userChoiceChar=='P' || userChoiceChar=='p' ||  // PURCHASE -must include member# //-PURCHASE amt. (must be > 0) //-IF member# exists, current purchase amt. is INCREASED by the purch. amt.
                                  userChoiceChar=='T' || userChoiceChar=='t' ||  // RETURN -must include member# //-RETURN amt. (must be > 0) //-IF member# exists, current purchase amt. is DECREASED by the purch. amt.
                                  userChoiceChar=='A' || userChoiceChar=='a' ||
                                  userChoiceChar=='Q' || userChoiceChar=='q');

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } 
                while (!userChoice);

                if (userChoiceChar=='L' || userChoiceChar=='l')
                {
                    int index = 0; //list index

                }
            }
        }
    }
}


/*================   Will implement these at some point   ================

            List<BaseMembership> BaseMembershipList = new List<BaseMembership>();
            BaseMembershipList.Add(new BaseMembership(6548974, "Test Test-0", "test@test.com-0", "regular-0", 99, 212));        // some lines of test data added
            BaseMembershipList.Add(new BaseMembership(6548974, "Test Test-0", "test@test.com-0", "regular-0", 99, 212));

            BaseMembershipList.Add(new Regular(6548974, "Test Test-1", "test@test.com-1", "regular-1", 99, 212, "regular-1"));
            BaseMembershipList.Add(new Regular(6548974, "Test Test-1", "test@test.com-1", "regular-1", 99, 212, "regular-1"));
            
            BaseMembershipList.Add(new Executive(6548974, "Test Test-2", "test@test.com-2", "regular-2", 99, 212, "executive-2"));
            BaseMembershipList.Add(new Executive(6548974, "Test Test-2", "test@test.com-2", "regular-2", 99, 212, "executive-2"));

            BaseMembershipList.Add(new NonProfit(6548974, "Test Test-3", "test@test.com-3", "regular-3", 99, 212, "nonprofit-3"));
            BaseMembershipList.Add(new NonProfit(6548974, "Test Test-3", "test@test.com-3", "regular-3", 99, 212, "nonprofit-3"));

            BaseMembershipList.Add(new Corporate(6548974, "Test Test-4", "test@test.com-4", "regular-4", 99, 212, "corporate-4"));
            BaseMembershipList.Add(new Corporate(6548974, "Test Test-4", "test@test.com-4", "regular-4", 99, 212, "corporate-4"));

            foreach (BaseMembership aMembership in BaseMembershipList)
            {
                Console.WriteLine(aMembership);
            }   */