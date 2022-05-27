using System;
namespace tier1_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<BaseMembership> baseMembershipList = new List<BaseMembership>();

            baseMembershipList.Add(new Regular(758799, "Alison Bauer-1", "test@test.com-1", "Regular Membership-1", 99, 212, .2));      //start of test data
            baseMembershipList.Add(new Regular(240394, "Litzy Reily-1", "test@test.com-1", "Regular Membership-1", 99, 382, .2 ));

            baseMembershipList.Add(new Executive(760706, "Whitney Kelly-2", "test@test.com-2", "Executive Membership-2", 149, 197, .2, .4));
            baseMembershipList.Add(new Executive(667815, "Micah McCann-2", "test@test.com-2", "Executive Membership-2", 149, 424, .2, .4));

            baseMembershipList.Add(new NonProfit(784179, "Kiley Gardner-3", "test@test.com-3", "NonProfit Membership-3", 99, 212, .8, true));
            baseMembershipList.Add(new NonProfit(307552, "Araceli Dunn-3", "test@test.com-3", "NonProfit Membership-3", 99, 212, .4, false));
            
            baseMembershipList.Add(new Corporate(860525, "Adelyn Sparks-4", "test@test.com-4", "Corporate Membership-4", 99, 212, .3));
            baseMembershipList.Add(new Corporate(954816, "Dwayne King-4", "test@test.com-4", "Corporate Membership-4", 99, 212, .3));

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
                    Console.WriteLine("U: Update email for an existing membership (will require membership ID). ");
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
                    //user needs to type their selected membership
                    Console.WriteLine("Please select the membership type you'd like (please enter an option listed below):");
                    Console.WriteLine("Regular?");
                    Console.WriteLine("Executive?");
                    Console.WriteLine("Non-Profit?"); 
                    Console.WriteLine("Corporate?");

                    string selectedMembershipType = Console.ReadLine();

                    //member selected regular membership
                    if (selectedMembershipType == "Regular"|| selectedMembershipType == "regular")
                    {
                        // random account # generator
                        Random generator = new Random();
                        double membershipID = Convert.ToDouble(generator.Next(0, 999999).ToString());
                        double newMembershipID = membershipID;
                        Console.WriteLine("New member ID:: " + newMembershipID);
                        Console.WriteLine("First and last name?:  ");
                        string newMemberName = Console.ReadLine();                    
                        Console.WriteLine("Please enter email address: ");
                        string newEmailAddress = Console.ReadLine();
                        Console.WriteLine("Account type selected: " + selectedMembershipType);
                        double regularAnnualCost = 99;
                        Console.WriteLine("Annual costs for Regular account: $"+ regularAnnualCost);
                        double newMemberBalance = 0.00;
                        Console.WriteLine("New members current balance: $" + newMemberBalance);
                        double newCashBackReward = .2;
                        Console.WriteLine("Cashback rewards for "+selectedMembershipType+": "+ newCashBackReward + "% back on all monthly purchases");
                        Console.WriteLine("Special offer for Regular account: 25% annual costs returned\n");

                        baseMembershipList.Add(new Regular(newMembershipID, newMemberName, newEmailAddress, selectedMembershipType, regularAnnualCost, newMemberBalance, newCashBackReward));
                    }
                    
                    //member selected executive membership
                    else if (selectedMembershipType == "Executive"|| selectedMembershipType == "executive")
                    {
                        // random account # generator
                        Random generator = new Random();
                        double membershipID = Convert.ToDouble(generator.Next(0, 999999).ToString());
                        double newMembershipID = membershipID;
                        Console.WriteLine("New member ID:: " + newMembershipID);
                        Console.WriteLine("First and last name?:  ");
                        string newMemberName = Console.ReadLine();
                        Console.WriteLine("Please enter email address: ");
                        string newEmailAddress = Console.ReadLine();                       
                        Console.WriteLine("Account type selected: " + selectedMembershipType);
                        double executiveAnnualCost = 149;
                        Console.WriteLine("Annual costs for Executive account: $"+ executiveAnnualCost);
                        double newMemberBalance = 0.00;
                        Console.WriteLine("New members current balance: $" + newMemberBalance);
                        double newExecutiveCashBackReward1 = .2;
                        double newExecutiveCashBackReward2 = .5;
                        Console.WriteLine("Cashback rewards for "+selectedMembershipType+": "+ newExecutiveCashBackReward1 + "% back on monthly purchases less than $1,000");
                        Console.WriteLine("Cashback rewards for "+selectedMembershipType+": "+ newExecutiveCashBackReward2 + "% back on monthly purchases greater than $1,000");
                        Console.WriteLine("Special offer for Executive account: 50% annual costs returned\n");

                        baseMembershipList.Add(new Executive(newMembershipID, newMemberName, newEmailAddress, selectedMembershipType, executiveAnnualCost, newMemberBalance, newExecutiveCashBackReward1, newExecutiveCashBackReward2));
                    }
                    
                    //member selected nonprofit membership
                    else if (selectedMembershipType == "Non-Profit" || selectedMembershipType == "non-profit" || selectedMembershipType == "NonProfit" || selectedMembershipType == "nonprofit")
                    {                        
                        Console.WriteLine("Are you Military or in Education? (True or False response, please)");
                        bool newMilOrEd = Convert.ToBoolean(Console.ReadLine());

                        // random account # generator
                        Random generator = new Random();
                        double membershipID = Convert.ToDouble(generator.Next(0, 999999).ToString());
                        double newMembershipID = membershipID;
                        Console.WriteLine("New member ID:: " + newMembershipID);            //TODO need to validate ID
                        Console.WriteLine("First and last name?:  ");
                        string newMemberName = Console.ReadLine();                    
                        Console.WriteLine("Please enter email address: ");
                        string newEmailAddress = Console.ReadLine();                        
                        Console.WriteLine("Account type selected: " + selectedMembershipType);
                        double nonprofitAnnualCost = 79;
                        Console.WriteLine("Annual costs for NonProfit account: $"+ nonprofitAnnualCost);
                        double newMemberBalance = 0.00;
                        Console.WriteLine("New members current balance: $" + newMemberBalance);
                        double newNonProfitCashBackReward = .4;
                        Console.WriteLine("Cashback rewards for "+selectedMembershipType+": "+ newNonProfitCashBackReward + "% back on all monthly purchases\n");

                        baseMembershipList.Add(new NonProfit(newMembershipID, newMemberName, newEmailAddress, selectedMembershipType, nonprofitAnnualCost, newMemberBalance, newNonProfitCashBackReward, newMilOrEd));
                    }

                    //member selected corporate membership
                    else if (selectedMembershipType == "Corporate"|| selectedMembershipType == "corporate")
                    {                      
                        // random account # generator
                        Random generator = new Random();
                        double membershipID = Convert.ToDouble(generator.Next(0, 999999).ToString());
                        double newMembershipID = membershipID;
                        Console.WriteLine("New member ID:: " + newMembershipID);
                        Console.WriteLine("First and last name?:  ");
                        string newMemberName = Console.ReadLine();
                        Console.WriteLine("Please enter email address: ");
                        string newEmailAddress = Console.ReadLine();                        
                        Console.WriteLine("Account type selected: " + selectedMembershipType);
                        double corporateAnnualCost = 129;
                        Console.WriteLine("Annual costs for Corporate account: $"+ corporateAnnualCost);
                        double newMemberBalance = 0.00;
                        Console.WriteLine("New members current balance: $" + newMemberBalance);
                        double newCorporateCashBackReward = .3;
                        Console.WriteLine("Cashback rewards for "+selectedMembershipType+": "+ newCorporateCashBackReward + "% back on all monthly purchases\n");
                        
                        baseMembershipList.Add(new Corporate(newMembershipID, newMemberName, newEmailAddress, selectedMembershipType, corporateAnnualCost, newMemberBalance, newCorporateCashBackReward));
                    }
                    
                }    
                if (userChoiceChar=='R' || userChoiceChar=='r')
                    foreach (BaseMembership aMembership in baseMembershipList)
                    {
                        Console.WriteLine(aMembership);       
                    }

                if (userChoiceChar=='U' || userChoiceChar=='u')
                {
                    Console.WriteLine("Please enter members ID to find:");
                    int currentID = Convert.ToInt32(Console.ReadLine());       

                    bool found=false;

                    for (int index = 0; index < baseMembershipList.Count; index++)
                    {
                        if (baseMembershipList[index].membershipID == currentID)
                        {
                            Console.WriteLine("Please enter members new email address:");
                            string updatedEmail = Console.ReadLine();
                            baseMembershipList[index].emailAddress = updatedEmail;
                            found = true;
                            Console.WriteLine("Member found. Email updated.");
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Member not found.");
                    }
                }
                
                if (userChoiceChar=='D' || userChoiceChar=='d')
                    Console.WriteLine("Please enter members ID to delete:");
                    int deleteID = Convert.ToInt32(Console.ReadLine());       

                    bool deleteFound=false;

                    for (int index = 0; index < baseMembershipList.Count; index++)
                    {
                        if (baseMembershipList[index].membershipID == deleteID)
                        {
                            baseMembershipList.RemoveAt(index);
                            Console.WriteLine("Member found and deleted.");
                            deleteFound = true;
                        }
                    }
                    if (!deleteFound)
                    {
                        Console.WriteLine("Member not found.");
                    }
                            
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















// var index = baseMembershipList.FindIndex(currentEmail => currentEmail.emailAddress == updatedEmail);