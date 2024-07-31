using HomeProject;
using Microsoft.VisualBasic;
using PowerArgs;
using System;

namespace program;

class Class
{
    static void Main(string[] args)
    {
        Class1 Bank = new Class1();

        Console.WriteLine("   bank name " + "       manager name " + "  bank budget " + "   bank age " + "  bank uniform ");

        Bank.BankName = " BANK MELLI IRAN ";  //this is bank name
        Bank.NameManager = " ALI REZAEE ";  //this is manager
        Bank.budgt = " 4500000000 ";  //how many budget does bank have
        Bank.BankAge = 1359;  //when does it born
        Bank.UniformColor = " blue ";   // what color does there uniform have
        Console.WriteLine(Bank.BankName + " " + Bank.NameManager + " " + Bank.budgt + "     " + Bank.BankAge + "       " + Bank.UniformColor);
        Console.WriteLine(" ****************************************************************************************** ");
        Console.WriteLine("the employee are :");
        Console.WriteLine(Ers.em1 + Ers.em2 + Ers.em3 + Ers.em4 + Ers.em5 + Ers.em6 + Ers.em7 + Ers.em8);
        Console.WriteLine(" ****************************************************************************************** ");
        Capsol count = new Capsol();
        count.Employee = 8;
        Console.WriteLine($"the number of employee is :{count.Employee}");
        Console.WriteLine(" ****************************************************************************************** ");
        List<string> Manager = new List<string>();
        Manager.Add(" wife manager: FATIMA AZIZI ");
        foreach (string list in Manager)
        {
        Console.WriteLine(list);
        Console.WriteLine(" ****************************************************************************************** ");
        }
        Class1 ne = new Class1();
        Console.WriteLine(ne + "she is 19 and she is from kermanshah");
        Console.WriteLine(" ****************************************************************************************** ");
    }
}
