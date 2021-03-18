using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Basic
{
    class student:person
    {
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { value = cgpa; }
        }
        private int creditcml;
        public int Creditcml
        {
            get { return creditcml; }
            set { value = creditcml; }
        }
        public student() { }
        public student(string name,string fathersname,string dob)
        {
            this.Name = name;
            this.Fathersname = fathersname;
            this.Dob = dob;
        }
    }
}
