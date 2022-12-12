using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class TeachersTab : UserControl
    {
        private MainForm Main;
        public Panel _createElementForm;
        public Form _activeForm;
        public listTeacher _listTeacher = new listTeacher();
        public TeachersTab(MainForm MForm)
        {
            Main = MForm;
            _createElementForm = this.createElementForm;
            InitializeComponent();
        }

        public void showTeachers()
        {
            humanListBox.Controls.Clear();
            for (int i = 0; i < _listTeacher.List.Count; i++)
            {
               // humanListBox.Controls.Add(new TeacherBox(_listTeacher.List[i], this));

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
            _listTeacher.addNewTeacher(new Teacher());
            showTeachers();
        }
        private void AddElement_Click(object sender, EventArgs e)
        {

            //openNewMenu(new CreateTeacherForm(this));

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
    }

}
