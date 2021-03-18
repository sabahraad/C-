using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Basic
{
    class person
    {
        private string name;
        public string Name
        {
             get{ return name; } 
             set {   name= value; } 
        }

        private string fathersname;
        public string Fathersname
        {
            get { return fathersname; }
            set{ fathersname=value  ; }
        }
        private string dob;
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public void Showinfo()
        {
            Console.WriteLine("NAME:" + name);
            Console.WriteLine("fatNAME:" + fathersname);
            Console.WriteLine("Date of Birth:" + dob);
        }
    }
}
