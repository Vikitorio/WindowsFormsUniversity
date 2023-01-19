using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using University.Classes;
using Newtonsoft.Json.Linq;

namespace University
{
    public class Student : Human
    {
        private int _admissionYear;
        private List<Subject> _subjectSet;
        private List<List<string>> _grades;
        private CourseWork _courseWork;

        public Student() : base()
        {
            _courseWork = new CourseWork();
            this._admissionYear = 2021;
        }
        public Student(string name, string surname, int age, Adress adress,int admissionYear, CourseWork courseWork, String email = "s") : base(name, surname, age, adress, email)
        {
            this._courseWork = courseWork;
            this._admissionYear = admissionYear;
        }

        public string dataToStr()
        {

            string str;
            str = base.dataToStr() + "\n" + "Subject: " + _admissionYear.ToString() + "\n" + "Person Data:";
            return str;
        }
        public CourseWork CourseTask
        {
            get { return this._courseWork; }
            set {  this._courseWork = value; }
        }

        public int AdmissionYear
        {
            get { return this._admissionYear; }
            set { this._admissionYear = value; }
        }
        /*public List<Subject> Subjects
        {
            get { return this._subjectSet; }
            set { this._subjectSet = value; }
        }
        */
        public List<List<string>> Grades
        {
            get { return this._grades; }
            set { this._grades = value; }
        }
        


    }
}
