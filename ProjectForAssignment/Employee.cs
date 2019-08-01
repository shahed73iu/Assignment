using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering
{
    public class Employee
    {
        public int x;
        private int y;
        protected int z;
        internal int a;
        public void calclulateSalary(int bonus, int age)
        {
            int t= x + y + z + a; //ekhane shob gulakei amra pabo. but main method 
                                  //theke pabo only "a"(same assembly tai pabe) ,"x" k... bakigula pabena 
            int tt= bonus + age; // amra chailei amader method er parameter gula use korte parbo        
                                 //onno funtion(same class er under er thaka function k) theke amra others function call korte parbo 


        }
    }
    public class SpecialEmployee :Employee
    {
        public void Dosomething()
        {
            int t = z + x + a;  // y pacchina cz ota private  ar z ke onno class e inherite kora jay evabe


        }
    }

}
