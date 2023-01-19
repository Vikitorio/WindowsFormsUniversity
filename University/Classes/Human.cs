using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace University
{
    public class Human
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Adress _adress;
        protected string _photo = "";
        protected string _mail = "";

        public Human()
        {
            this._name = "Name";
            this._surname = "Surname";
            this._age = 18;
            this._adress = new Adress();
            this._mail = "mikhalchevskiu@gmail.com";
        }
        public Human(string name, string surname, int age, Adress adress, string mail = "sadasd")
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._adress = adress;
            _mail = mail;
        }
        public void WriteToJson(string fileLink)
        {
            Human human = this;
            string JsonData = JsonConvert.SerializeObject(human);
            File.WriteAllText(fileLink, JsonData);

        }
        public void changeInfo()
        {
            Console.WriteLine("Введите новое имя: ");
            this._name = Console.ReadLine();
            Console.WriteLine("Введите новую фамилию: ");
            this._surname = Console.ReadLine();
            Console.WriteLine("Введите новий возраст: ");
            this._age = Int32.Parse(Console.ReadLine());
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void printInfo()
        {
            Console.WriteLine(dataToStr());
        }
        public string dataToStr()
        {
            string str;
            str = "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" + _adress.adressToString();
            return str;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string Mail {
            get { return this._mail; }
            set { this._mail = value; }
        }
    }
}

