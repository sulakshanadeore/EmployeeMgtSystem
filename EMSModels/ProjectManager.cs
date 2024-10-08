using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    public class ProjectManager:Employee
    {
        int _NoofProjectsManaged;

        public void AcceptProjectManagerDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter no of projects handled");
            _NoofProjectsManaged=Convert.ToInt32(Console.ReadLine());

        }

        public void ShowProjectManagerDetails()
        { 
           
        base.DisplayDetails();
        Console.WriteLine(_NoofProjectsManaged);

        }

    }
}
