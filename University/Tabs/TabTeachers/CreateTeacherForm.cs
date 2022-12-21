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
            _mainForm._listTeacher.AddTeacher(newTeacher);
            _mainForm.showTeachers();
            _mainForm.SendDataToMain();

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

        private void CreateTeacherForm_Load(object sender, EventArgs e)
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
            catch (Exception) { 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LName_Click(object sender, EventArgs e)
        {

        }

        private void _salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _country_TextChanged(object sender, EventArgs e)
        {

        }

        private void _city_TextChanged(object sender, EventArgs e)
        {

        }

        private void _street_TextChanged(object sender, EventArgs e)
        {

        }

        private void _house_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
