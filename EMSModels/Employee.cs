﻿
namespace EMSModels
{
       public class Employee
    {
        //Department department;
        
        int _empid;
        string _ename;
        string _city;
        double _sal;
        string _email;


       public void AcceptDetails()
        {
         //   department._internalUse=1;
           // department._protectedInternal = 1;
           
            Console.WriteLine("Enter empid");
            _empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ename");
            _ename = Console.ReadLine();
        }

        public void DisplayDetails() {

            Console.WriteLine($"The empid= {_empid}");
            Console.WriteLine($"The employee name= {_ename}");

        }

    }
}