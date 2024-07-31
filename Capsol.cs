using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeProject;
internal class Capsol
{
    private int _Employee;

    public int Employee
    {
        get
        { return _Employee; }
        set
        {
            if (value == 8)
            {

                Console.WriteLine("they are Bank employee");
                _Employee = 8;
            }


            else
            {
                Employee = value;
            }
        }
    }
}