using System;

namespace comp4_4_5
{
    abstract class Account //: IWithdrawal, IDeposit      // make base class abstract || TODO inherit interfaces
    {

        public string accountHolderName     //  name get/set
        { get; set; }

        public string accountNumber        //  acct ID get/set
        { get; set; }

        public string accountType        //  acct type get/set
        { get; set; }
    
        public double accountBalance        // current bal get/set
        { get; set; }

        public double depositAmount
        { get; set; }

        public double withdrawalAmount
        { get; set; }

        //public double depositAmount;  TODO revisit whatever this was
        public Account()        // constructor w/o parameters
        {
            accountHolderName = "";
            accountType = "";
            accountNumber = "";           
            accountBalance = 0.0;
        }

        public Account (string newAccountHolderName, string newAccountType, string newAccountNumber, double newAccountBalance)        // constructor w/ parameters
        {
            accountHolderName = newAccountHolderName;
            accountNumber = newAccountNumber;
            accountType = newAccountType;
            accountBalance = newAccountBalance;
        }
        public override Deposit()        // TODO apply methods from IDeposit interface
        {
            return newDepositAmount;
        }
        public void Withdrawal(newWithdrawal);       // TODO apply methods from IWithdrawal interface
        {
            return newWithdrawal;
        }

        public override string ToString()
        {
            return "Account holder: " + accountHolderName + "\nAccount type: " + accountType + "\nAccount number: " + accountNumber + "\nAccount balance: $" + accountBalance + "\n";
        }

    }       //end class
}       //end namespace


            /*====================================================================

                            WILL ADD THIS AT SOMEPOINT

            ======================================================================