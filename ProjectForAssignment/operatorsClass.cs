using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class operatorsClass
    {
        public void operatorsFunction()
        {
            int x = 0, y = 0;
            int z = x + y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = x << y;
            z = x >> y;

            if(x<y)
            {

            }
            if (x > y)
            {

            }
            if (x <= y)
            {

            }
            if (x >= y)
            {

            }
            if (x == y)
            {

            }

            if (x != y)
            {

            }

            z = x & y; // 1  &1 korle 1 hoy
            z = x | y; //1|0 korle 1 hy
            z = x ^ y; //XOR operator 



            bool a = true;
            bool b = false;
            bool c = a && b;
                 c = a || b;
                c = !a;
            string s = "hello";
            string ss = s ?? "Empty";
            ss = (x == null) ? "Empty" : s;


            z = x > y ? x : y;
            x++;
            x--;
            ++x;
            --x;

            z = ++x * 5;
            z = x++ * 5;

            x += 5;
            x -= 5;
            x *= 5;
            x /= 5;



        }
    }

}
