using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentPortalApp;

namespace StudentPortalApp
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Module> modules = new List<Module>();
        string name, gender, idNum, yearOfStudy;
        int age;
        int projectMark, semesterMark, examMark;
        double averageMark;
        string results;
        Module module;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void IDTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GenderTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void YearOfStudyTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // get marks 
             projectMark = Convert.ToInt32(ProjectMarksList.Text);
             examMark = Convert.ToInt32(ExamMarksList.Text);
             semesterMark = Convert.ToInt32(SemesterMarksList.Text);

            Module module = new Module(ModuleList.Text,projectMark,semesterMark,examMark) ;
            name = nameTextBox.Text;
            idNum = IDTextBox.Text;
            age = Convert.ToInt32(AgeTextBox.Text);
            yearOfStudy = YearOfStudyTextBox.Text;
            
            Student student = new Student(name, idNum, age, gender, yearOfStudy, module);
            if (!students.Contains(student))
            {
                students.Add(student);
                StudentsList.Items.Add(name);
            }




            // determine the average mark for the marks 
            determinePass(module);
        }

        private void determinePass(Module module)
        {
            averageMark = (module.projectMark * 0.2) + (module.examMark * 0.40) + (module.semesterMark * 0.40);
            AverageMarksTextBox.Text = "" + averageMark;

            // display whether the student passed or failed
            if (averageMark > 49)
            {
                ResultsTextBox.Text = "PASSED";
            }
            else
            {
                ResultsTextBox.Text = "FAILED";
            }
        }

        private void updateFields(Student student)
        {
            nameTextBox.Text = "";
            GenderTextBox.Text = "";
            AgeTextBox.Text = "";
            YearOfStudyTextBox.Text = "";
            IDTextBox.Text = "";
            ProjectMarksList.Text = "0";
            SemesterMarksList.Text = "0";
            ExamMarksList.Text = "0";
            ResultsTextBox.Text = "";
            AverageMarksTextBox.Text = "0";
        }
        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            GenderTextBox.Text = "";
            AgeTextBox.Text = "";
            YearOfStudyTextBox.Text = "";
            IDTextBox.Text = "";
            ProjectMarksList.Text = "0";
            SemesterMarksList.Text = "0";
            ExamMarksList.Text = "0";
            ResultsTextBox.Text = "";
            AverageMarksTextBox.Text = "0";
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ResultsTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void AverageMarksTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void ExamMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SemesterMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectMarksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModuleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Student student in students)
            {
                if (StudentsList.SelectedItem.Equals(student.name))
                {
                    nameTextBox.Text = student.name;
                    GenderTextBox.Text = student.gender;
                    AgeTextBox.Text = ""+student.age;
                    YearOfStudyTextBox.Text = student.yearOfStudy;
                    IDTextBox.Text =student.idNum;
                    ProjectMarksList.Text = "0";
                    determinePass(student.module);
                    /*SemesterMarksList.Text = "0";
                    ExamMarksList.Text = "0";
                    ResultsTextBox.Text = "";
                    AverageMarksTextBox.Text = "0";*/

                }
            }
            
        }
    }
}
