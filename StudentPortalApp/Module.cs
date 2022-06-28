using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalApp
{
    class Module
    {
        private string moduleName { get; set; }
        private int projectMark { get; set; }
        private int semesterMark {get;set ;}
        private int examMark { get; set; }
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
