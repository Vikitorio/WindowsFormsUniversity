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
    public partial class MainForm : Form
    {
        private Form _curentTab;
        private listTeacher _listTeacher = new listTeacher();
        public MainForm()
        {
            InitializeComponent();
            openTab(new TabTeachers(this), BtnTeachers);
        }

        public void showTeachers()
        {
            /*
            humanListBox.Controls.Clear();
            for (int i = 0; i < _listTeacher.List.Count; i++)
            {
                humanListBox.Controls.Add(new TeacherBox(_listTeacher.List[i], this));
                
            }
            */


        }
        public listTeacher getListTeacher() {
            return this._listTeacher;
        }
        private void createTeacher_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddElement_Click(object sender, EventArgs e)
        {

            

        }


        private void CreateDefaultTeacher_Click(object sender, EventArgs e)
        {
            _listTeacher.addNewTeacher(new Teacher());
            showTeachers();
        }

        /*private void AddNode_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _listTeacher.List.Count(); i++)
            {
                treeView1.Nodes.Add(_listTeacher.List[i].Name);

            }

        }*/
        public void openTab(Form newTab , Object button) {
            
            if (_curentTab != null)
            {
                _curentTab.Close();
            }
            Form Tab = newTab;
            Tab.TopLevel = false;
            Tab.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(Tab);
            Tab.Dock = DockStyle.Fill;
            Tab.BringToFront();
            Tab.Show();
            _curentTab = Tab;
        }

        /*private void addSubNode_Click(object sender, EventArgs e)
        {
           string teacherName = treeView1.SelectedNode.Text;
            for (int i = 0; i < _listTeacher.List.Count(); i++)
            {
                if (_listTeacher.List[i].Name == teacherName && _listTeacher.List[i].Students.Count()>0) {
                    for (int j = 0; j < _listTeacher.List[i].Students.Count(); j++) {
                        treeView1.SelectedNode.Nodes.Add(_listTeacher.List[i].Students[j].Name);
                            }
                }

            }
            
        }
        */

        private void TabTeachers_Click(object sender, EventArgs e)
        {

            openTab(new TabTeachers(this), sender);
        }

        private void humanListBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCharts_Click(object sender, EventArgs e)
        {
            openTab(new TabCharts(this), sender);
        }

        /* private void BtnCharts_Click(object sender, EventArgs e)
         {
             UserControl Tab = new ChartTab();
             this.Controls.Add(Tab);
             Tab.Dock = DockStyle.Fill;
             Tab.BringToFront();
             _curentTab = Tab;
         }
        */
        public listTeacher ListTeachers
        {

            get { return _listTeacher; }
            set { this._listTeacher = value; }

        }

        private void BtnGrid_Click(object sender, EventArgs e)
        {
            openTab(new TabDataGrid(this), sender);
        }
    }

}
