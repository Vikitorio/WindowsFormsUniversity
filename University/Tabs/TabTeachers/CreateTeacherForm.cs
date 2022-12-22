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
        private listTeacher _listTeacher = listTeacher.GetInstance();
        public CreateTeacherForm(TabTeachers mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
    
        private void SavePerson_Click(object sender, EventArgs e)
        {  
           string name = this.name.Text;
            string surname = this.surname.Text;
            int age = int.Parse(this.age.Text);
            int salary = int.Parse(this.salary.Text);
            string country = this.country.Text;
            string city = this.city.Text;
            string street = this.street.Text;
            int house = int.Parse(this.house.Text);
            Adress adress = new Adress(country,city,street,house);
            Teacher newTeacher = new Teacher(name, surname, age, adress, salary);
            newTeacher.Photo = photoBox.ImageLocation;
            _listTeacher.AddTeacher(newTeacher);
            _mainForm.showTeachers();
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
            catch (Exception) { 
            }
        }
    }
}
