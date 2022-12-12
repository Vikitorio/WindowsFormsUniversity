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
    public partial class CreateTeacherForm : Form
    {
        private TabTeachers _mainForm ;
        public CreateTeacherForm(TabTeachers mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
    
        private void SavePerson_Click(object sender, EventArgs e)
        {
            
           string name = _name.Text;
            string surname = _surname.Text;
            int age = Int32.Parse(_age.Text);
            int salary = Int32.Parse(_salary.Text);
            string country = _country.Text;
            string city = _city.Text;
            string street = _street.Text;
            int house = Int32.Parse(_house.Text);
            Adress adress = new Adress(country,city,street,house);
            Teacher newTeacher = new Teacher(name, surname, age, adress, salary);
            _mainForm._listTeacher.AddTeacher(newTeacher);
            _mainForm.showTeachers();
           
        }

        private void _admissionYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void _age_TextChanged(object sender, EventArgs e)
        {

        }

        private void _surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void _name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
