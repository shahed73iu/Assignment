using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
   // class InterfaceClass
   class Abstractclass
    {
        // public void interfacefunction()
       public void Abstractfunction()
        {

            //var missile = new Missile();
            //missile.fire();

            //var gun = new Machinegun();
            //gun.fire();
           // int[] numbers = new int[100]; 

            weapon[] we = new weapon[2];
            we[0] = new Missile();
            we[1] = new Machinegun();
   
            for (int i = 0; i < 2; i++)
            {
                we[i].fire(); 
            }

        }
    }
    public interface Iweapon
    {
        void fire();

    }
    
    public abstract class weapon  // eta abrstract class 
    {
        protected int DamagePower; // eta common property tai rekhe dilam ekhane 
        public abstract void fire(); // ei abstract method er main kaj ki amra ekhane define korini
        // tai child class e override use korte hobe jodi "fire()" use korte hoy tobe 
        

    }
    public class Missile : weapon
    {
        public Missile()
        {
            DamagePower = 200;

        }
        public override void fire()
        {
            Console.WriteLine("Missile was fired with damage amount : {0}\n",DamagePower); 
        }

    }

    public class Machinegun : weapon
    {
        public Machinegun()
        {
            DamagePower = 100;

        }
        public override void fire()
        {
            Console.WriteLine("Machinegun was fired with damage amount : {0}\n", DamagePower);
        }

    }

}
