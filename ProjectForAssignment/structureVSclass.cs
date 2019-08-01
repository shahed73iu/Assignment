using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class structureVSclass
    {
        int x;
        long y; //64 bit
        short z; // 16 bit
        string b;  //eta class baki shob struct
        char a;
        DateTime f;
        float c;
        double e;
        uint g;
        bool h;
        decimal i;
        //egula premitive
        public void Vte()
        {
            int p, q;
            p = 5; // p te 5 rakhlam
            q = p; // p er value ta q te copy hoye gese
                   //p ar q alada memory address e ache
            q = 6;
            Console.WriteLine("p : {0}, Q :{1}", p, q);
            Console.WriteLine("yeeeeeeeeeeeeee\n");

        }
        public void structureVsClass()
        {
            // class reference type 
            Student s1 = new Student();
            s1.name = "Shahed";
            s1.age = 23;

            Student s3 = s1;                 // tara same memory k point kore ase 
            s3.name = "zahid";              // tai s2 ke change korle s1 o change hoye jay 
            s3.age = 21;
            Console.WriteLine("Student 1 name :{0}, Student 1 Age:{1}", s1.name, s1.age);
            Console.WriteLine("Student 2 name :{0}, Student 2 Age:{1}", s3.name, s3.age);


            //ekhon dekhbo structure value type je eta 

            point point = new point();
            point.x = 10;
            point.y = 20;

            point point2 = point;
            point2.x = 40;
            point2.y = 50;
            Console.WriteLine("Point_1 x: {0} , Point_1 y :{1}", point.x, point.y);
            Console.WriteLine("Point_2 x: {0} , Point_2 y :{1}", point2.x, point2.y);
        }
    }
    public struct point //value type eta 
    {
        public int x;
        public int y;
    }

    class Student // reference type eta 
    {
        public string name;
        public int age;

    }
}

