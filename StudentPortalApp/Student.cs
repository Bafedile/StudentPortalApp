using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalApp
{
     class Student
    {
        private string name { get; set; }
        private string idNum { get; set; }
        private int age { get; set; }
        private string gender { get; set; }
        private string yearOfStudy { get; set; }
        private Module module;

        public Student()
        {

        }

        public Student(string name, string idNum,int age,string gender,string yearOfStudy,Module module)
        {
            this.name = name;
            this.idNum = idNum;
            this.age = age;
            this.gender = gender;
            this.yearOfStudy = yearOfStudy;
        }


    }
}
