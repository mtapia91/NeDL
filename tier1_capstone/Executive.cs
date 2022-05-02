using System;

namespace tier1_capstone
{
    class Executive: MembershipInfo      //standard class
    {
        public string executiveMembership      //get; set; all properties
        { get; set; }

        public Executive()        //default constructor
        {
            executiveMembership = "";
        }
        public Executive(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalMonthlyPurchases, string newExecutiveMembership): base(newMembershipID, newMemberName, newEmailAddress, newMembershipType, newAnnualCost, newTotalMonthlyPurchases)       //another constructor
        {
            executiveMembership = newExecutiveMembership;
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