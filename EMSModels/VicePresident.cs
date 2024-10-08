using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    public class VicePresident:ProjectManager
    {
        int _mgtExpYrs;
        public void AcceptVicePresidentDetails()
        {
            base.AcceptProjectManagerDetails();
            Console.WriteLine("Enter Mgt Experience");
            _mgtExpYrs=Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayVicePresidentDetails()
        {
            base.ShowProjectManagerDetails();
            Console.WriteLine($"Management experience {_mgtExpYrs}");
        }


    }
}
