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
              public override string ToString()
        {
            return base.ToString + "\n" + "\n";
        }
    }
}