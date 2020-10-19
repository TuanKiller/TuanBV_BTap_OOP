using System;
using System.Collections.Generic;
using System.Text;

namespace TuanBV_BT2_OOP
{
    public class Official
    {
        public string position { get; set; }    
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string level { get; set; }
        public string task { get; set; }
        public string major { get; set; }
        protected Official() { }
        public bool SearchByName(string index)
        {
            if (this.name.Contains(index))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
