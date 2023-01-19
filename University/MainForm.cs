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
        private Form _currentTab;
        private Button _currentButton;
        private listTeacher _listTeacher = listTeacher.GetInstance();
        private TabTeachers _tabTeachers;
        public MainForm()
        {
            InitializeComponent();
            openTab(new TabTeachers(this), BtnTeachers);
            ActivateButton(this.BtnTeachers);
        }
        public void openTab(Form newTab , Object button) {
            
            if (_currentTab != null)
            {
                _currentTab.Close();
            }
            Form Tab = newTab;
            Tab.TopLevel = false;
            Tab.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(Tab);
            Tab.Dock = DockStyle.Fill;
            Tab.BringToFront();
            Tab.Show();
            _currentTab = Tab;

   
        }
        private void ActivateButton(Button btn) {
            if (_currentButton != null) {
                _currentButton.BackColor = Color.FromArgb(79, 103, 166);
            }
 
            //btn.BackColor = Color.Red;
            _currentButton = btn;
            _currentButton.BackColor = Color.FromArgb(73, 90, 133);
        }
        private void TabTeachers_Click(object sender, EventArgs e)
        {
            ActivateButton(this.BtnTeachers);
            openTab(new TabTeachers(this), sender);
        }
        private void BtnCharts_Click(object sender, EventArgs e)
        {
            ActivateButton(this.BtnCharts);

            openTab(new TabCharts(this), sender);
        }
        private void BtnGrid_Click(object sender, EventArgs e)
        {
            ActivateButton(this.BtnGrid);
            openTab(new TabDataGrid(this), sender);
        }
        private void SaveData_Click(object sender, EventArgs e)
        {
            _listTeacher.WriteToJson();
        }
        private void LoadData_Click(object sender, EventArgs e)
        {
            _listTeacher.readFromJson();
            openTab(new TabTeachers(this), BtnTeachers);
        }
        public listTeacher ListTeachers
        {

            get { return _listTeacher; }
            set { this._listTeacher = value; }

        }
    }

}
