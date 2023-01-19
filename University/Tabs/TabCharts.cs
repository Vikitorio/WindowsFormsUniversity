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
using University.Classes;

namespace University.Tabs
{
    public partial class TabCharts : Form
    {
        private MainForm _mainForm;
        private listTeacher _listTeacher = listTeacher.GetInstance();
        public TabCharts(MainForm Main)
        {
            _mainForm = Main;
            InitializeComponent();
            fillCharts();
            fillNods();
        }
        public void fillCharts() {
            for (int i = 0; i < _listTeacher.List.Count(); i++) {
                TeachersChart.Series["Students"].Points.AddXY(_listTeacher.List[i].Name, _listTeacher.List[i].Students.Count());

            }
        }
        public void fillNods() {
            for (int i = 0; i < _listTeacher.List.Count(); i++)
            {
                treeView1.Nodes.Add(_listTeacher.List[i].Name);
               
                   
                for (int j = 0; j < _listTeacher.List[i].Students.Count(); j++)
                        {
                    String strStudent = _listTeacher.List[i].Students[j].Name +" "+ _listTeacher.List[i].Students[j].Surname;
                    treeView1.Nodes[i].Nodes.Add(strStudent);
                    String courseTitle = _listTeacher.List[i].Students[j].CourseTask.Title;
                    String courseDeadLine = _listTeacher.List[i].Students[j].CourseTask.DeadLine.ToString();
                    treeView1.Nodes[i].Nodes[j].Nodes.Add(courseTitle +" - "+ courseDeadLine);
                    if(_listTeacher.List[i].Students[j].CourseTask.DeadLine < DateTime.Now)
                        treeView1.Nodes[i].Nodes[j].Nodes[0].BackColor = Color.Red;
                        }

            }
        }

        private void BtnSendNotification_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _listTeacher.List.Count; i++) {
                for (int j = 0; j < _listTeacher.List[i].Students.Count(); j++)
                {
                    if (_listTeacher.List[i].Students[j].CourseTask.DeadLine < DateTime.Now) {
                        EmailSender.sendEmail(_listTeacher.List[i].Students[j].Mail, "Чайс вийшов", "твоя курсова робота не здана вчасно");
                    }
                        
                }
            }
            
        }


    }
}
