using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{ 
class Student:Person
{
    string program;
    int year;
    double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
    {
        Program = program;
        Year = year;
        Fee = fee;
        
        
    }



        override public string ToString()
    {
            
        return base.ToString()+" program=" + Program + " year =" + Year + " Fee =" + Fee+"]";


    }


}
}