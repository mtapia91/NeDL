using System;

namespace MoviesClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
            Movies[] moviesArray = new Movies [25];

            //Looping through each array elelment and instantiating each obj.
            //*Constructor with no parameters will be used.
            for (int i = 0; i < moviesArray.Length; i++)
            {
                moviesArray[i] = new Movies();
            }

            moviesArray[2].setName("Cheaper By The Dozen");
            moviesArray[2].MRating = 2;
            moviesArray[5].setName("Frozen 2");
            moviesArray[5].MRating = 5;
            moviesArray[9].setName("US");
            moviesArray[9].MRating = 5;

            for (int i = 0; i < moviesArray.Length; i++)
            {
                if(!(((moviesArray[i]).getName())==null))
                    Console.WriteLine(moviesArray[i]);
            }

        } // end Main
    } // end class
} // end namespace