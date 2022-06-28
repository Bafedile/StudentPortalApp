using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalApp
{
     class Student
    {
        public string name { get; set; }
        public string idNum { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string yearOfStudy { get; set; }
        public Module module;

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
