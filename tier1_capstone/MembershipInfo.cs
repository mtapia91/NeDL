using System;

namespace tier1_capstone
{
    class MembershipInfo      //abstract class
    {
        public double membershipID      //get; set; all properties
        { get; set; }
        public string memberName
        { get; set; }
        public string emailAddress
        { get; set; }
        public string membershipType
        { get; set; }
        public double annualCost
        { get; set; }
        public double totalMonthlyPurchases
        { get; set; }
        public MembershipInfo()        //default constructor
        {
            membershipID = 0;
            memberName = "";
            emailAddress = "";
            membershipType = "";
            annualCost = 0;
            totalMonthlyPurchases = 0;
        }
        public MembershipInfo(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newTotalMonthlyPurchases)       //another constructor
        {
            membershipID = newMembershipID;
            memberName = newMemberName;
            emailAddress = newEmailAddress;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            totalMonthlyPurchases = newTotalMonthlyPurchases;
        }
        /* public abstract double Purchase();      //abstract method that all child classes will implement
                -must include member#
                -purchase amt. (must be > 0)
                -IF member# exists, current amt. of purch. is increased by the purch. amt.

        public abstract double Return();        //abstract method that all child classes will implement
                -must include member#
                -return amt. (must be > 0)
                -IF member# exists, current amt. of purch. is decreased by the purch. amt. */

        public override string ToString()
        {
            return "Member ID: " + membershipID + "\nMember name: " + memberName + "\nEmail address : " + emailAddress + "\nType: " + membershipType + "\nAnnual cost: $" + annualCost + "\nTotal monthly purchase: $" + totalMonthlyPurchases;
        }
    }
}