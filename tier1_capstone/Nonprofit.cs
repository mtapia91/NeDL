using System;

namespace tier1_capstone
{
    class NonProfit: MembershipInfo      //standard class
    {
        public string nonProfitMembership      //get; set; all properties
        { get; set; }

        public NonProfit()        //default constructor
        {
            nonProfitMembership = "";
        }
        public NonProfit(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalMonthlyPurchases, string newNonProfitMembership): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newTotalMonthlyPurchases)       //another constructor
        {
            nonProfitMembership = newNonProfitMembership;
        }
              public override string ToString()
        {
            return base.ToString + "\n" + "\n";
        }
    }
}