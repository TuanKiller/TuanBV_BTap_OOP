using System;
using System.Collections.Generic;
using System.Text;

namespace TuanBV_BT2_OOP
{
    public class Employee : Official
    {
        public Employee(string position, string name, int yearOfBirth, string gender , string address, string major)
        {
            this.position = position;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.gender = gender;
            this.address = address;
            this.major = major;
        }
    }
}
