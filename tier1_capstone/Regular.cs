using System;

namespace tier1_capstone
{
    class Regular: MembershipInfo      //standard class
    {
        public string regularMembership      //get; set; all properties
        { get; set; }

        public Regular()        //default constructor
        {
            regularMembership = "";
        }
        public Regular(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalMonthlyPurchases, string newRegularMembership): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newTotalMonthlyPurchases)       //another constructor
        {
            regularMembership = newRegularMembership;
        }
        /* public abstract double Purchase();      //abstract method that all child classes will implement
        {                                           //-must include member#
            return membershipID                     //-purchase amt. (must be > 0)
                                                    //-IF member# exists, current amt. of purch. is increased by the purch. amt.
        }

        public abstract double Return();        //abstract method that all child classes will implement
                                                    //-must include member#
                                                    //-return amt. (must be > 0)
                                                    //-IF member# exists, current amt. of purch. is decreased by the purch. amt. */

        public override string ToString()
        {
            return base.ToString + "\nTotal monthly purchase: $" + totalMonthlyPurchases;
        }
    }
}