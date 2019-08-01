using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class Property
    {
        public void propertyFunction()
        {
            var person = new person()
                person.Name = "Emamuddin";


        }
    }
    class person
    {
        //public string name { get; set; }

        /* egula na likhe uporer ta likhlei hobe 
       

       private string name;
       public string getName()
       {
           return name;
       }
       public void setName(string n)
       {
           name = n; 

       }
       // Set method e parameter na thakle "value" ei keyword ta use korte hoy
       jemon
      * set
      * {
      *       if(value==null)
      *              name=string.Empty;
      *       else
      *              name= value;
      * }
      //_________________________________________*/
        
        private string name;

       public void  setName(string n)
       {
            if (n != string.Empty)
                name = n;
            else
                name = string.Empty;

           hasNameChanged=true;
       }
       public string  getName()
       {
            if (name == null)
                return string.Empty;
            else
                return name;

       }

       private bool hasNameChanged;

        
      
    }
}
