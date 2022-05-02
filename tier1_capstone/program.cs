using System;
namespace tier1_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MembershipInfo> membershipInfoList = new List<MembershipInfo>();     //test data

            membershipInfoList.Add(new MembershipInfo(6548974, "Test Test", "test@test.com", "regular", 99, 212));
               
        
            foreach (MembershipInfo aMembership in membershipInfoList)
            {
                Console.WriteLine(aMembership);
            }  
        }
    }
}


/*================   Will implement these at some point   ================


string membershipId = String.Format("32{0}", r.ToString("D6"));
*/