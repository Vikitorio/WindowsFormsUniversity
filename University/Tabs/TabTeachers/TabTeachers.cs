using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.Tabs
{
    public partial class TabTeachers : Form
    {
        private MainForm Main;
        public Panel _createElementForm;
        public Form _activeForm;
        public listTeacher _listTeacher = new listTeacher();
        public TabTeachers(MainForm MForm)
        {
            Main = MForm;
            this._listTeacher = Main.ListTeachers;
            _createElementForm = this.createElementForm;
            InitializeComponent();
            showTeachers();
        }
     
   

        public void showTeachers()
        {
            humanListBox.Controls.Clear();
            for (int i = 0; i < _listTeacher.List.Count; i++)
            {
                humanListBox.Controls.Add(new TeacherBox(_listTeacher.List[i], this));

            }


        }
        public void openNewMenu(Form newForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            /*newForm.Dock = DockStyle.Fill;*/
            this.createElementForm.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();

        }
        private void CreateDefaultTeacher_Click(object sender, EventArgs e)
        {
            Teacher first = new Teacher("Vasilii", "Procopenco", 44, new Adress(), 10000);
            first.AddStudent(new Student());
            first.AddStudent(new Student());
            first.AddStudent(new Student());
            Teacher second = new Teacher("Viktor", "Barashkov", 41, new Adress(), 10000);
            second.AddStudent(new Student());
            second.AddStudent(new Student());
            second.AddStudent(new Student());
            Teacher third = new Teacher("Genady", "semchenko", 41, new Adress(), 10000);
            third.AddStudent(new Student());
            third.AddStudent(new Student());
            third.AddStudent(new Student());
            _listTeacher.addNewTeacher(first);
            _listTeacher.addNewTeacher(second);
            _listTeacher.addNewTeacher(third);
            showTeachers();
        }
        private void AddElement_Click(object sender, EventArgs e)
        {

            openNewMenu(new CreateTeacherForm(this));

        }

        private void AddElement_Click_1(object sender, EventArgs e)
        {

        }

        private void humanListBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createElementForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabTeachers_Close(object sender, FormClosingEventArgs e)
        {
            Main.ListTeachers = this._listTeacher;
        }
    }
}
