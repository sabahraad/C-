using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Basic
{
    class teacher:person
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { value = salary; }
        }
        public teacher() { }
        public teacher(string name,string fathersname,string dob)
        {
            this.Name = name;
            this.Fathersname = fathersname;
            this.Dob = dob;
        }

    }
}
