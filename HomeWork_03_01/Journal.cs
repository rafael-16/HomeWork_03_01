using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_03_01
{
    internal class Journal
    {
        private string _name = string.Empty;
        private string _date = string.Empty;
        private string _description = string.Empty;
        private string _phone = string.Empty;
        private string _email = string.Empty;

        public void SetName(string name) { _name = name; }
        public  string GetName() { return _name; }
        public void SetDate(string date) { _date = date; }
        public string GetDate() { return _date;}
        public void SetDescription(string description) { _description = description; }
        public string GetDescription() { return _description;}
        public void SetPhone(string phone) { _phone = phone; }
        public string GetPhone() { return _phone;}
        public void SetEmail(string email) { _email = email; }
        public string GetEmail() { return _email;}

        public void Data_Entry()
        {
            Console.Write("Введите название журнала: ");
            _name = Console.ReadLine()!;

            Console.Write("Введите год основания журнала: ");
            _date = Console.ReadLine()!;

            Console.Write("Опишите о чем журнала: ");
            _description = Console.ReadLine()!;

            Console.Write("Введите номер телефона: ");
            _phone = Console.ReadLine()!;

            Console.Write("Введите E-mail журнала: ");
            _email = Console.ReadLine()!;
        }

        public void Data_Output()
        {
            Console.WriteLine("Название журнала: " + _name);
            Console.WriteLine("Год основания: " + _date);
            Console.WriteLine("Описание журнала: " + _description);
            Console.WriteLine("Телефон: " + _phone);
            Console.WriteLine("E-mail: "+ _email);
        }
    }
}
