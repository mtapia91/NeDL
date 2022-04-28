using System;
using System.Collections.Generic;       // needed for lists

namespace comp4_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();        // create bank account list

            accountList.Add(new Account ("ZsaZsa Gabor", "Checking", "6543210", 32564));        // hard code Account Class test data

            accountList.Add(new Account ("ZsaZsa Gabor", "Checking", "6546284", 9564));

            accountList.Add(new Account ("ZsaZsa Gabor", "Checking", "5487461", 3215));

            accountList.Add(new Account ("ZsaZsa Gabor", "Savings", "8452540", 52465));
            
            accountList.Add(new Account ("ZsaZsa Gabor", "Savings", "4845896", 4569));
            
            foreach (Account aAccount in accountList)        // foreach print list
            {
                Console.WriteLine(aAccount);
            }
        }
    }
}