using System;

namespace comp4_4_5
{
    class CustomerAccount //: IWithdrawal, IDeposit      // make base class abstract || TODO inherit interfaces
    {

        public string accountHolderName     //  name get/set
        { get; set; }

        public string accountNumber        //  acct ID get/set
        { get; set; }

        public string accountType        //  acct type get/set
        { get; set; }
    
        public double accountBalance        // current bal get/set
        { get; set; }

        //public double depositAmount;
        public CustomerAccount()       // constructor w/o parameters
        {
            accountHolderName = "";
            accountType = "";
            accountNumber = "";           
            accountBalance = 0.0;
        }

        public CustomerAccount (string newAccountHolderName, string newAccountType, string newAccountNumber, double newAccountBalance)        // constructor w/ parameters
                {
                    accountHolderName = newAccountHolderName;
                    accountNumber = newAccountNumber;
                    accountType = newAccountType;
                    accountBalance = newAccountBalance;
                }
            /*====================================================================

                            WILL ADD THESE INTERFACE METHODS AT SOMEPOINT

            ======================================================================

            public override double Deposit()        // TODO apply methods from IDeposit interface
                    {
                        return newDepositAmount;
                    }
                    public void Withdrawal(double newWithdrawal);       // TODO apply methods from IWithdrawal interface */

        public override string ToString()
        {
            return "Account holder: " + accountHolderName + "\nAccount type: " + accountType + "\nAccount number: " + accountNumber + "\nAccount balance: $" + accountBalance + "\n";
        }

    }       //end class
}       //end namespace
