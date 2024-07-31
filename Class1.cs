using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeProject;

internal class Class1 : IInterface1
{
    public string BankName;
    public string NameManager;
    public string budgt;
    public string UniformColor;
    public int BankAge;

    public string Information(string name)
    {
        throw new NotImplementedException();

        return " she is 19 and she is from kermanshah" + name;
    }
 
}

