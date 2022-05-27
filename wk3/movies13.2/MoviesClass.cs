using System;

namespace MoviesClass
{
    class Movies
    {
        //Two Pieces of data are being stored fo reach object.
        //MName is the retaurant name. To show the difference in how values can be stored,
        //MName will be an instance variable.
        //MRating is the Movies rating. To show the difference in how values cna be stored,
        //MRating is the Movies will be an automatic property.

        //This is the instance variable so it myst be declared. It's private so only methods of the
        //object can access it.
        private string MName; //Movies name

        //This is the automatic property variable. The get and set methods are being created too.
        public int MRating //property
            { get; set; }


            //This is the default constructor when no values are being passed.
            public Movies ()
            {
                MName = null;
                MRating = -1;
            }

            //This is the constructor when two values are passed.
            public Movies (string newMovies, int newRating)
            {
                MName = newMovies;
                MRating = newRating;
            }

            //Since MName is not define as a property, we need to create the get and set methods
            // for it.
            public string getName()
            {
                return MName;
            }

            public void setName (string newName)
            {
                MName = newName;
            }


            //This overrides ToString so an object can be printer out with the WriteLine.

            public override string ToString()
            {
                return "Movie Title: \n" +MName +" \nRating: \n" + MRating;
            }

    }// class end
}// namespace end