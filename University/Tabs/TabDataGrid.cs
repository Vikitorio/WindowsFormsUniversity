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
    public partial class TabDataGrid : Form
    {
        private MainForm _mainForm;
        private listTeacher _listTeachers;
        public TabDataGrid(MainForm Main)
        {
            _mainForm = Main;
            getCurrentList();
            InitializeComponent();
            fillGridTeachersTable();
        }
        public void getCurrentList()
        {
            this._listTeachers = _mainForm.ListTeachers;
        }
        public void fillGridTeachersTable() {
            for (int i = 0; i < dataGridTeachers.Columns.Count; i++) {
                dataGridTeachers.Columns[i].ValueType = typeof(string);
            }
            for (int i = 0; i < _listTeachers.List.Count; i++) {
                Teacher TempT = _listTeachers.List[i];
                dataGridTeachers.Rows.Add(TempT.Name ,TempT.Surname, TempT.Age, TempT.salary, TempT.getStudentsStr());
            }   
        }
    }
}
