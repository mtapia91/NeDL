using System;

namespace tier1_capstone
{
    class Executive: BaseMembership, ISpecial      //standard class + inheritance + interface
    {
        public double executiveCashBackReward1      //get; set; both cash back properties
        { get; set; }
        public double executiveCashBackReward2
        { get; set; }
        public Executive () : base ()       //default constructor
        {
         executiveCashBackReward1 = 0.0;
         executiveCashBackReward2 = 0.0;
        }
        public Executive(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newCurrentBalance, double newExecutiveCashBackReward1, double newExecutiveCashBackReward2): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newCurrentBalance)       //another constructor
        {
            executiveCashBackReward1 = newExecutiveCashBackReward1;
            executiveCashBackReward2 = newExecutiveCashBackReward2;
        }
        public override double CashBack()       //abstract method 
        {
            double totalCashBack;
            if (currentBalance <= 1000)
            {
                totalCashBack = currentBalance * executiveCashBackReward1;
            }
            else 
            {
                totalCashBack = currentBalance * executiveCashBackReward2;
            }
            return totalCashBack;
        }
        public double Special()     //interface method
        {
            return annualCost * .50;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCash back reward percentage for option 1: " + executiveCashBackReward1 + "\nCash back reward percentage for option 2: " + executiveCashBackReward2 + "\nSpecial offer: " + Special() + "\n";
        }
    }
}