using System;

namespace tier1_capstone
{
    class Regular: BaseMembership, ISpecial      //standard class + inheritance + interface
    {
        public double regularCashBackReward      //get; set; regular cash back property
        { get; set; }

        public Regular() :base ()        //default constructor
        {
            regularCashBackReward = 0.0;
        }
        public Regular(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalCurrentBalance, double newRegularCashBackReward, double newPurchaseTotal): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newTotalCurrentBalance)       //another constructor
        {
            regularCashBackReward = newRegularCashBackReward;
        }
        public override double CashBack()       //abstract method from interface
        {
            double totalCashBack = currentBalance * regularCashBackReward;
            return totalCashBack;
        }
        public double Special()        //interface method
        {
            return annualCost * .25;
        }

        public override string ToString()       //class ToString
        {
            return base.ToString + "\nCashback Rewards Percentage: " + regularCashBackReward + "\nSpecial Offer: " + Special();
        }
    }
}