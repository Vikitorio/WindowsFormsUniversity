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
            getCurrentList();
            _createElementForm = this.createElementForm;
            InitializeComponent();
            showTeachers();
        }

        public void getCurrentList() {
            this._listTeacher = Main.ListTeachers;
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
        public void SendDataToMain() {
            Main.ListTeachers = this._listTeacher;
        }
        private void CreateDefaultTeacher_Click(object sender, EventArgs e)
        {
            Teacher first = new Teacher("Vasilii", "Procopenco", 44, new Adress(), 10000);
            Classes.CourseWork cours1 = new Classes.CourseWork("Philosophi",DateTime.Now,new DateTime(2023,01,18));
            first.AddStudent(new Student("Viktor","Xzkov",22,new Adress(),2021,cours1));
            first.AddStudent(new Student("Mikhail", "Dzerzinski", 22, new Adress(), 2021, cours1));
            Teacher second = new Teacher("Sveta", "Kobleva", 41, new Adress(), 10000);
            Classes.CourseWork cours2 = new Classes.CourseWork("Math", DateTime.Now, new DateTime(2024, 01, 18));
            second.AddStudent(new Student("Oleg", "Rice", 22, new Adress(), 2021, cours2));
            second.AddStudent(new Student("Dima", "Zuker", 22, new Adress(), 2021, cours2));
            second.AddStudent(new Student("Sophia", "Xzkov", 22, new Adress(), 2021, cours2));
            Teacher third = new Teacher("Genady", "Semchenko", 41, new Adress(), 10000);
            Classes.CourseWork cours3 = new Classes.CourseWork("Literatura", DateTime.Now, new DateTime(2023, 01, 18));
            third.AddStudent(new Student("Mikola", "Bahov", 22, new Adress(), 2021, cours3));
            third.AddStudent(new Student("Ivan", "Dorn", 22, new Adress(), 2021, cours3));
            third.AddStudent(new Student("Evgeniy", "Sitsun", 22, new Adress(), 2021, cours3));
            _listTeacher.addNewTeacher(first);
            _listTeacher.addNewTeacher(second);
            _listTeacher.addNewTeacher(third);
            showTeachers();
            SendDataToMain();
        }
        private void AddElement_Click(object sender, EventArgs e)
        {
            openNewMenu(new CreateTeacherForm(this));
        }
        private void TabTeachers_Close(object sender, FormClosingEventArgs e)
        {
            SendDataToMain();
        }

        private void sendData(object sender, ControlEventArgs e)
        {
            SendDataToMain();
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            _listTeacher.WriteToJson();
        }
        private void loadData_Click(object sender, EventArgs e)
        {
            _listTeacher.readFromJson();
            showTeachers();
        }
    }
}
