using System;

namespace tier1_capstone
{
    abstract class BaseMembership      //abstract class
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
        public double currentBalance
        { get; set; }
        public BaseMembership()        //default constructor
        {
            membershipID = 0.0;
            memberName = "";
            emailAddress = "";
            membershipType = "";
            annualCost = 0.0;
            currentBalance = 0.0;
        }
        public BaseMembership(double newMembershipID, string newMemberName, string newEmailAddress, string newMembershipType, double newAnnualCost, double newCurrentBalance)       //another constructor
        {
            membershipID = newMembershipID;
            memberName = newMemberName;
            emailAddress = newEmailAddress;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            currentBalance = newCurrentBalance;
        }
        public double Purchase(double purchaseTotal)        //method all children classes will implement
        {
            currentBalance = currentBalance + purchaseTotal;
            return currentBalance;
        }
        public double Return(double returnTotal)        //method all children classes will implement
        {
            currentBalance = currentBalance - returnTotal;
            return currentBalance;
        }
        public abstract double CashBack();      //abstract method

        public override string ToString()
        {
            return "Member ID: " + membershipID + "\nMember name: " + memberName + "\nEmail address : " + emailAddress + "\n Membership type: " + membershipType + "\nAnnual cost: $" + annualCost + "\nCurrent monthly purchase balance: $" + currentBalance;
        }
    }
}