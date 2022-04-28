using System;
using System.Collections.Generic;       // needed for lists

namespace comp4_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomerAccount> customerAccountList = new List<CustomerAccount>();        // create bank account list

            customerAccountList.Add(new CustomerAccount ("Melissa Tapia", "Checking", "6543210", 32564));        // hard code test data
            customerAccountList.Add(new CustomerAccount ("Susana Tapia", "Savings", "8452540", 52465));
            customerAccountList.Add(new CustomerAccount ("Juliana Vazquez-Tapia", "Savings", "4845896", 4569));
            customerAccountList.Add(new CustomerAccount ("Jaydin Vazquez-Tapia", "Checking", "6546284", 9564));
            customerAccountList.Add(new CustomerAccount ("Juillet Vazquez-Tapia", "Checking", "5487461", 3215));
            
            foreach (CustomerAccount aCustomerAccount in customerAccountList)        // foreach print list
            {
                Console.WriteLine(aCustomerAccount);
            }
        }
    }
}