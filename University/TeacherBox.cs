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
    public partial class TeacherBox : UserControl
    {
        private TabTeachers _mainForm;
        private Teacher _teacher;
        private String _teacherName;
        public TeacherBox(TabTeachers mainForm)
        {
            this._mainForm = mainForm;
            this._teacher = new Teacher();
            this._teacherName = _teacher.Name + _teacher.Surname;
            InitializeComponent();
            setTeacherBoxInfo();
        }
        public TeacherBox(Teacher teacher, TabTeachers mainForm)
        {
            this._mainForm = mainForm;
            this._teacher = teacher;
            this._teacherName = _teacher.Name + _teacher.Surname;
            InitializeComponent();
            setTeacherBoxInfo();
        }
        public void setTeacherBoxInfo() {
            this.teacherName.Text = this._teacherName;
        }

        public string NameSurname 
        {
            get{ return _teacherName; }
            set { this._teacherName = value; setTeacherBoxInfo(); }
        }
        public Teacher Teacher
        {
            get { return _teacher; }
            set { this._teacher = value; setTeacherBoxInfo(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            _mainForm._activeForm.Close();
            String StudentInput="";
            for (int i = 0; i < Teacher.Students.Count; i++) {
                StudentInput += Teacher.Students[i].dataToStr() +"\n--------------------\n" ;
            }
            RichTextBox textBox = new RichTextBox();
            textBox.Size = new System.Drawing.Size(200, 400);
            textBox.Text = StudentInput;
            _mainForm._createElementForm.Controls.Add(textBox);

        }


        private void addStudent_Click(object sender, EventArgs e)
        {
            _mainForm.openNewMenu(new CreateStudentForm(_mainForm , this));
        }
    }
}
