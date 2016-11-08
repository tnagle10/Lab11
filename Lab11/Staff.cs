using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff:Person
    {
        string school;
        double pay;

        public Staff(string name, string address, string school, double pay) :base(name,address)
        {
            School = school;
            Pay = pay;
        }

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }


        override public string ToString()
        {

            return "Staff[Person[name=" + Name + " address=" + Address + "]"+" school="+School+" pay ="+Pay+"]";
           

        }


    }
}
