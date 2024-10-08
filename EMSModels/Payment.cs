using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    public class Payment
    {
        public double Amt { get; set; }

        public double Pay()
        {
            Console.WriteLine($"Paid in cash Rs. {Amt}");
            return Amt;
        }

        public void Pay(long cardno,string bankname)
        {
            Console.WriteLine($"Paid by card {cardno} of bank {bankname} of Rs. {Amt}");
            
        }

        public void Pay(string personname,long cardno)
        {
            Console.WriteLine($"Paid by card {cardno} of bank {personname}");
           
        }



    }
}
