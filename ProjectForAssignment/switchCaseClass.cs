
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class switchCaseClass
    {
        public void switchCaseFunction()
        {
            int x = 5;
            switch(x)
            {
                case 1:
                    Console.WriteLine("X is 1");
                    break;
                case 2:
                    Console.WriteLine("X is 2");
                    break;


                default:

                    Console.WriteLine("NO match");
                    break;


            }
            String Name = "EmamUddin";
            
            switch(Name)
            {
                case "EmamUddin":
                    Console.WriteLine("found");
                    break;
                case "Zahid":
                    Console.WriteLine("Found");
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;


            }

        }
    }
}
