using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class daynamicType
    {
        public void dynamic()
        {
            dynamic something  = 100;

            something = "Hello";
            something = true;
            something = new { Name = "EmamUddin ", Age = 23};
            Console.WriteLine(something); 

          

        }

    }
}
