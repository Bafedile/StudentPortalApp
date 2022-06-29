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
using MySql.Data.MySqlClient;
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
        string results,query;
        Module module;
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        string queryResponse = "";
        public Form1()
        {
            InitializeComponent();
            generateNumbers();
            connectToDatabase();
            populateStudentList();
        }

        public string getQueryResult(string query,MySqlConnection conn)
        {
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                /* queryResponse += String.Format("#{0},{1},{2},{3},{4},{5},{6} ",reader["id"], reader["firstname"],
                     reader["lastname"], reader["idnumber"], reader["age"], 
                     reader["gender"], reader["yearofstudy"]);*/
                queryResponse += String.Format("#{0},{1}", reader["firstname"], reader["lastname"]);
            }

            reader.Close();
            return queryResponse;
             
        }
       
        public void populateStudentList()
        {
            string[] studentInfo = queryResponse.Split('#');

            for(int i = 0; i < studentInfo.Length; i++)
            {
                StudentsList.Items.Add(studentInfo[i]);
            }
        }
        public void connectToDatabase()
        {
            string server = "localhost";
            string database = "Studentportal";
            string username = "bafedile";
            string password = "Amogelang#5%";
            string connString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + username + ";PASSWORD=" + password+";";
            connection = new  MySqlConnection(connString);
            connection.Open();
            Console.WriteLine("Database Connected");
            query = "select * from student_info;";
            Console.WriteLine(getQueryResult(query, connection));
        }
        public void generateNumbers()
        {
            for(int i = 0; i < 101; i++)
            {
                ProjectMarksList.Items.Add(i);
                SemesterMarksList.Items.Add(i);
                ExamMarksList.Items.Add(i);
            }
            
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

            module = new Module(ModuleList.Text,projectMark,semesterMark,examMark) ;

            // add module to modules list
            modules.Add(module);
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
            nameTextBox.Text = student.name;
            GenderTextBox.Text = student.gender;
            AgeTextBox.Text = "" + student.age;
            YearOfStudyTextBox.Text = student.yearOfStudy;
            IDTextBox.Text = student.idNum;

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
            ModuleList.Text = "";
            
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
            // get the student name from the selected index 
            name = StudentsList.Text;

            // query the database to retrieve information about the student 
            string[] studInfo = name.Split(',');

            query = String.Format("select * from student_info where firstname =" +
                " {0} and lastname = {1};", studInfo[0], studInfo[1]);

            queryResponse = getQueryResult(query, connection);

            studInfo = queryResponse.Split('#');

            nameTextBox.Text = studInfo[1]+" " + studInfo[2];
            IDTextBox.Text = studInfo[3];
            AgeTextBox.Text = studInfo[4];
            GenderTextBox.Text = studInfo[5];
            YearOfStudyTextBox.Text = studInfo[6];
            
            
        }
    }
}
