using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class AnonymousType
    {
         
                public void Anonymous()
                {

                        //etar last e semicolon nai kintu format ta mathay rakhbo
                        var person = new  // new disi kintu new er pore kono 
                    {
                        FirstName = "Shahed",
                        LastName = "Emam",
                        Age = 23
                    };
                        Console.WriteLine("Name {0} {1} and age is {2}", person.FirstName, person.LastName, person.Age);

            /*  istantly chailei banate parbo ,
             *  joikhn assign korchi tokhn e decalre kora jacche,,,,
             *  arekta copy banano jacchena
             *  ETAI hocche anonymous type
             */


                        var person2 = new person3(); // eta holo nicher person3 class er akta instance
                                         // evabe na kore amra uporer system follow kore instantly define korte pari
                                         // ki mojaaaaaaaaaaaaa yeeeeeee
                }   
    }

    
    class person3
    {
        public String FirstName;
        public String LastName;
        public int  Age;

    }
 
}
