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
    public class listHuman
    {
        private List<Human> _listHumans;

        public listHuman()
        {
            _listHumans = new List<Human>();
        }

        public void AddHuman(Human a)
        {
            _listHumans.Add(a);
        }
        public void printHumans()
        {
            for (int i = 0; i < _listHumans.Count(); i++)
            {
                _listHumans[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name)
        {
            for (int i = 0; i < _listHumans.Count(); i++)
            {
                if (_listHumans[i].Name == name)
                {
                    _listHumans[i].printInfo();
                }

            }
        }
        public void changeObjByName(string name)
        {
            for (int i = 0; i < _listHumans.Count(); i++)
            {
                if (_listHumans[i].Name == name)
                {
                    _listHumans[i].changeInfo();
                }

            }
        }

        public string showListStr()
        {
            string listData = "";
            for (int i = 0; i < _listHumans.Count(); i++)
                listData += _listHumans[i].dataToStr();
            return listData;
        }
        /*public void WriteToJson()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json files (*.json)|*.json";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                List<Human> list = this._listHumans;
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
                this._listHumans = JsonConvert.DeserializeObject<List<Human>>(jsonData);
            }
        }
        */
       
        public void sortByAgeLowToHigh()
        {
            List<Human> list = _listHumans;
            Human temp;
            for (int i = 1; i < list.Count(); i++)
            {
                for (int j = 1; j < list.Count(); j++)
                {
                    if (list[j] < list[j - 1])
                    {
                        temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
        public void sortByAgeHightToLow()
        {
            List<Human> list = _listHumans;
            Human temp;
            for (int i = 1; i < list.Count(); i++)
            {
                for (int j = 1; j < list.Count(); j++)
                {
                    if (list[j] > list[j - 1])
                    {
                        temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }

        public List<Human> List
        {
            get { return _listHumans; }
            set { this._listHumans = value; }
        }
    }


}
