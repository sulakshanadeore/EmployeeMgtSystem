using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    internal class Department
    {
        private int _deptno;//only inside the class
        internal int _internalUse;//no inheritance required, used using class reference
        protected int _protectedData;//only inherited classes can use it
        protected internal int _protectedInternal;//inherited classes as well as other classes, but in the same assembly
        public void Show()
        {
            Console.WriteLine(_deptno);
            Console.WriteLine(_protectedData);
            Console.WriteLine(_protectedInternal);
        }
    }

    internal class HR:Department
    {
        Department _dept;

        public void SomeMethod()
        {
            //base._protectedData;\
            base._protectedInternal = 1;
        }
    }
}
