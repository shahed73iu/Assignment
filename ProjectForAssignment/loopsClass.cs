using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class loopsClass
    {
        public void loopsFumction()
        {
            int a= 5, b = 0;

            for (int x = 0, y=5 ; x < 10 && y<10; x++,y--)

            {

            }
            while(a>b)
            {
                a++;

            }

            do
            {
                Console.WriteLine("hello");
            }
            while (a < 10);

            string[] names = new string[10];

            names[0] = "Shahed";
            names[1] = "Emam";

            foreach(string name in names)
            {
                Console.WriteLine(name);

            }


                


        }
    }
}
