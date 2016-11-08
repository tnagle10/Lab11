using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string name;
        private string address;

        public Person(string name1, string address1)
        {
            name = name1;
            Address = address1;

        }

        public string Name
        {
            get
            {
                return name;
            }

        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        override public string ToString()
        {

            return "Person[name=" + Name + " address= " + Address + "]";

        }



    }
}
