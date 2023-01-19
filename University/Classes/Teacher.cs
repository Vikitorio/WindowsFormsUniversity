using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    enum Subject { None, Math, Fisics, History, Biology, English }
    public class Teacher : Human
    {
        private Subject _subject;
        private List<Student> _students;
        private int _salary;


        public Teacher() : base()
        {
            _students = new List<Student>();
                this._subject = Subject.None;
            this._salary = 6500;
        }
        public Teacher(string name, string surname, int age, Adress adress, int salary, string email = "1234@gmail.com") : base(name, surname, age, adress,email)
        {
            _students = new List<Student>();
            this._salary = salary;

        }
        public string getStudentsStr() {
            string result = "";
            for (int i = 0; i < _students.Count; i++) {
                result += _students[i].Name + " " + _students[i].Surname + "\n";
                    }
            return result;
        }
        public void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public string dataToStr()
        {
            string str;
            str = base.dataToStr() + "\n" + "Subject: " + _subject.ToString() + "\n" + "Salary" + _salary + "\n" + "Person Data:";
            return str;
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
       /* public Subject SubjectsT
        {
            get { return _subject; }
            set { _subject = value; }
        }
       */
        public int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}

