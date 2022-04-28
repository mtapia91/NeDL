using System;

namespace comp4_4_5
{
    class Checking: Account        // inherit parent class

    {
        public double checkingFee  // checking fee property
        { get; set; }

        public Checking (): base ()     //TODO constructor w/o parameters
        {
            checkingFee = 0;
        }
                                            //======vvv===== TODO constructor w/ parameters ======vvv=====\\
        public Checking (string newAccountHolderName, string newAccountType, string newAccountNumber, double newAccountBalance, double newCheckingFee): base (newAccountHolderName, newAccountType, newAccountNumber, newAccountBalance)
        {
            checkingFee = newCheckingFee;
        }       

                //TODO method to calculate checking annual fee

        //TODO create withdrawal method that can be up to, but no exceed, 50% of acct bal

        //TODO base ToString + check class ToString

    }       //end class
}       //end namespace