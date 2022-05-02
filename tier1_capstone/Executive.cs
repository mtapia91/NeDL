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
              public override string ToString()
        {
            return base.ToString + "\n" + "\n";
        }
    }
}