using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Tabs;

namespace University
{
    public partial class CreateStudentForm : Form
    {
        private TabTeachers _mainForm;
        private TeacherBox _teacherBox;
        public CreateStudentForm(TabTeachers mainForm, TeacherBox teacherBox)
        {
            this._mainForm = mainForm;
            this._teacherBox = teacherBox;
            InitializeComponent();
        }

        private void SavePerson_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string surname = _surname.Text;
            int age = Int32.Parse(_age.Text);
            int admission = Int32.Parse(_admissionYear.Text);
            string country = _country.Text;
            string city = _city.Text;
            string street = _street.Text;
            int house = Int32.Parse(_house.Text);
            Adress adress = new Adress(country, city, street, house);
            Student newStudent = new Student(name, surname, age, adress, admission);
            _teacherBox.Teacher.Students.Add(newStudent);

        }
    }
}
