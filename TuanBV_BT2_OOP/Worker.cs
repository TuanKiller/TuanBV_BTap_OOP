using System;
using System.Collections.Generic;
using System.Text;

namespace TuanBV_BT2_OOP
{
    public class Worker: Official
    {
        public Worker(string position , string name , int yearOfBirth, string gender, string address, string level)
        {
            this.position = position;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.gender = gender;
            this.address = address;
            this.level = level;
        }
    }
}
