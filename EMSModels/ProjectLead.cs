using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    public class ProjectLead:SeniorEmployee
    {

        public ProjectLead()
        {
            
        }
        public string ProjectName { get; set; }
        public ProjectLead(int empid, string ename, string city,string projname):base(empid,ename,city)
        {
            ProjectName = projname;

        }
    }
}
