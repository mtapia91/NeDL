using System;

namespace tier1_capstone
{
    class NonProfit: BaseMembership      //standard class
    {
        public double nonProfitCashBack      //get; set; all properties
        { get; set; }
        public bool militaryOrEducation
        { get; set; }
        public NonProfit() : base ()        //default constructor
        {
            nonProfitCashBack = 0.0;
            militaryOrEducation = false;
        }
        public NonProfit(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newCurrentBalance , double newNonProfitCashBack, bool newMilitaryOrEducation): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newCurrentBalance)       //another constructor
        {
            nonProfitCashBack = newNonProfitCashBack;
            militaryOrEducation = newMilitaryOrEducation;
        }
        public override double CashBack()
        {
            double CashBack;
            if (militaryOrEducation  == true)
            {
                CashBack = (nonProfitCashBack * 2 * currentBalance);
            }
            else
            {
                CashBack = (nonProfitCashBack * currentBalance);
            }
            return CashBack;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCash Back Rewards Percentage: "  + nonProfitCashBack + "\nMiliary or Educational?: " + militaryOrEducation + "\n";
        }
    }
}