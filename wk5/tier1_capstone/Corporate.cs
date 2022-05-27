using System;

namespace tier1_capstone
{
    class Corporate: BaseMembership      //standard class
    {
        public double corporateCashBack      //get; set; all properties
        { get; set; }

        public Corporate() : base ()        //default constructor
        {
            corporateCashBack = 0.0;
        }
        public Corporate(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newCurrentBalance, double newCorporateCashBack): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newCurrentBalance)       //another constructor
        {
            corporateCashBack = newCorporateCashBack;
        }
        public override double CashBack()       //abstract method from interface
        {
            double totalCashBack = currentBalance * corporateCashBack;
            return totalCashBack;
        } 
        public override string ToString()
        {
            return base.ToString() + "\nCorporate Cash Back Percentage (monthly): " + corporateCashBack + "\n";
        }
        
    }
}