using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            student S1 = new student ("Raad", "Shahed", "18-07-1998");
            S1.Showinfo();
            teacher T1 = new teacher("SAAd", "Shahed", "04-02-1996");
            T1.Showinfo();

        }
    }
}
