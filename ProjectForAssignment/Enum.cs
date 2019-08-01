using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAssignment
{
    class Enum
    {
        public void EnumFunction()
        {
            var user = new UserType();

            if(User.status ==RegistrationStatus.Active && user.Type==UserType.Admin)
            {
                Console.WriteLine("Login Successfull");
            }
        }

    }
    public class User
    {
        public string name { get; set; }
        public Age {get;set;}
        public RegistrationStatus status {get;set;}
        public UserType type{get;set}


    public enum  WeekDays
    {
        monday,
        tuesday,
        wednessday,
        thrusday,
        Friday,
        Saturday,
        sunday
    }
    public enum RegistrationStatus
    {
        Inactive,
        Blocked,
        Active

    }
    public enum UserType
    {
        Member,
        Support,
        Admin,
        SuperAdmin
    }
}
