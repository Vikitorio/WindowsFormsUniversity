using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace University
{
    public sealed class listTeacher : listHuman
    {
        private List<Teacher> _listTeachers;

        private  listTeacher()
        {
            _listTeachers = new List<Teacher>();
        }
        private static listTeacher _instance;
        public static listTeacher GetInstance()
        {
            if (_instance == null)
            {
                _instance = new listTeacher();
            }
            return _instance;
        }

        public void addNewTeacher(Teacher teacher)
        {
            _listTeachers.Add(teacher);
        }
        public void AddTeacher(Teacher a)
        {
            _listTeachers.Add(a);
        }
        public void printTeachers()
        {
            for (int i = 0; i < _listTeachers.Count(); i++)
            {
                _listTeachers[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name)
        {
            for (int i = 0; i < _listTeachers.Count(); i++)
            {
                if (_listTeachers[i].Name == name)
                {
                    _listTeachers[i].printInfo();
                }

            }
        }


        public string showListStr()
        {
            string listData = "";
            for (int i = 0; i < _listTeachers.Count(); i++)
                listData += _listTeachers[i].dataToStr();
            return listData;
        }
        /*public void WriteToJson(string fileLink, List<Human> list)
         {

             string JsonData = JsonConvert.SerializeObject(list);
             File.WriteAllText(fileLink, JsonData);

         }
        */
        public void WriteToJson()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json files (*.json)|*.json";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                List<Teacher> list = this._listTeachers;
                string JsonData = JsonConvert.SerializeObject(list);
                File.WriteAllText(saveFileDialog1.FileName, JsonData);
            }

        }

        public void readFromJson()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Json files (*.json)|*.json";
            openFileDialog1.Title = "Save";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                string jsonData = File.ReadAllText(openFileDialog1.FileName);
                this._listTeachers = JsonConvert.DeserializeObject<List<Teacher>>(jsonData);
            }
        }
        public List<Teacher> List
        {
            get { return _listTeachers; }
            set { this._listTeachers = value; }
        }
    }
}
