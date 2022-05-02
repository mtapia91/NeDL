using System;

namespace tier1_capstone
{
    class Corporate: MembershipInfo      //standard class
    {
        public string corporateMembership      //get; set; all properties
        { get; set; }

        public Corporate()        //default constructor
        {
            corporateMembership = "";
        }
        public Corporate(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalMonthlyPurchases, string newCorporateMembership): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newTotalMonthlyPurchases)       //another constructor
        {
            corporateMembership = newCorporateMembership;
        }
    /*  public virtual void Purchase();      //abstract method that all child classes will implement
        {                                           //-must include member#
            return membershipID                     //-purchase amt. (must be > 0)
                                                    //-IF member# exists, current amt. of purch. is increased by the purch. amt.
        }

        public virtual void Return();        //abstract method that all child classes will implement
                                                    //-must include member#
                                                    //-return amt. (must be > 0)
                                                    //-IF member# exists, current amt. of purch. is decreased by the purch. amt. */
        public override string ToString()
        {
            return base.ToString + "\n" + "\n";
        }
    }
}