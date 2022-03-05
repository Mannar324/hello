using System;
using practice.classes;

namespace practice
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            employee oemployee = new employee();
            oemployee.Employeeid = 1;
            oemployee.setemployeename("mohamed");
            oemployee.salary = 2000;
            oemployee.departmentname = "sales";

            employee oemployee2 = new employee();
            oemployee2.Employeeid=2 ;
            oemployee2.Employeename="ahmed";
            oemployee2.salary = 8000;
            oemployee2.departmentname = "software";

            employee oemployee3 = new employee();
            oemployee3.Employeeid = 3;
            oemployee3.Employeename="saif";
            oemployee3.salary = 5000;
            oemployee3.departmentname = "purchase";
            Console.WriteLine(oemployee.employeename);
            Console.WriteLine(oemployee2.employeename);
            Console.WriteLine(oemployee3.employeename);
        }
    }
}
