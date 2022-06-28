using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalApp
{
    class Module
    {
        public string moduleName { get; set; }
        public int projectMark { get; set; }
        public int semesterMark {get;set ;}
        public int examMark { get; set; }
        public Module()
        {

        }
        public Module(string name,int projectMark,int semesterMark,int examMark)
        {
            this.moduleName = moduleName;
            this.projectMark = projectMark;
            this.semesterMark = semesterMark;
            this.examMark = examMark;
        }
    }
}
