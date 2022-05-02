using System;           // || work on this dead last

interface ITransactions      //TODO establish withdrawal interface
{
    void Deposit(double depositAmount);      //declare define deposit method
    void Withdrawal(double withdrawalAmount);    // declare defined withdrawal method     
}