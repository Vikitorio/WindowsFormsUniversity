using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace University.Tabs
{
    public partial class TabCharts : Form
    {
        private MainForm _mainForm;
        private listTeacher _listTeacher;
        public TabCharts(MainForm Main)
        {
            _mainForm = Main;
            _listTeacher = Main.ListTeachers;

            InitializeComponent();
            fillCharts();
            fillNods();
        }
        public void fillCharts() {
            listTeacher List = _mainForm.getListTeacher();
            for (int i = 0; i < List.List.Count(); i++) {
                TeachersChart.Series["Students"].Points.AddXY(List.List[i].Name, List.List[i].Students.Count());

            }
        }
        public void fillNods() {
            for (int i = 0; i < _listTeacher.List.Count(); i++)
            {
                treeView1.Nodes.Add(_listTeacher.List[i].Name);
               
                   
                for (int j = 0; j < _listTeacher.List[i].Students.Count(); j++)
                        {
                    treeView1.Nodes[i].Nodes.Add(_listTeacher.List[i].Students[j].Name);
                        }

            }
        }
        private void TeachersChart_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
