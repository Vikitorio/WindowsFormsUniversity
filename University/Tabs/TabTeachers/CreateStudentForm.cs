using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Classes;
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
            string name = this.name.Text;
            string surname = this.surname.Text;
            int age = int.Parse(this.age.Text);
            int admission = Int32.Parse(admissionYear.Text);
            string country = this.country.Text;
            string city = this.city.Text;
            string street = this.street.Text;
            int house = int.Parse(this.house.Text);
            CourseWork dateCourseWork = new CourseWork(courseWorkTitle.Text,DateTime.Now,deadLine.Value);
            Adress adress = new Adress(country, city, street, house);
            Student newStudent = new Student(name, surname, age, adress, admission,dateCourseWork);
            _teacherBox.Teacher.Students.Add(newStudent);
            _mainForm.SendDataToMain();

        }

        private void photoBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string photoSrc = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                dialog.ShowDialog();
                photoSrc = dialog.FileName;
                photoBox.ImageLocation = photoSrc;
            }
            catch (Exception)
            {
            }
        }
    }
}
