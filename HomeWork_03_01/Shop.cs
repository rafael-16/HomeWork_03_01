using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_03_01
{
    internal class Shop
    {
        private string _name = string.Empty;
        private string _adress = string.Empty;
        private string _description = string.Empty;
        private string _phone = string.Empty;
        private string _email = string.Empty;

        public void SetName(string name) { _name = name; }
        public string GetName() { return _name; }
        public void SetAdress(string adress) {  _adress = adress; }
        public string GetAdress() { return _adress;}
        public void SetDescription(string description) { _description = description; }
        public string GetDescription() { return _description;}
        public void SetPhone(string phone) { _phone = phone; }
        public string GetPhone() { return _phone;}
        public void SetEmail(string email) { _email = email; }
        public string GetEmail() { return _email;}

        public void Data_Entry()
        {
            Console.Write("Введите название мфгазина: ");
            _name = Console.ReadLine()!;

            Console.Write("Введите адрес магазина: ");
            _adress = Console.ReadLine()!;

            Console.Write("Опишите чем торгует магазин: ");
            _description = Console.ReadLine()!;

            Console.Write("Введите номер телефона: ");
            _phone = Console.ReadLine()!;

            Console.Write("Введите E-mail магазина: ");
            _email = Console.ReadLine()!;
        }

        public void Data_Output()
        {
            Console.WriteLine("Название магазина: " + _name);
            Console.WriteLine("Адрес магазина: " + _adress);
            Console.WriteLine("Описание магазина: " + _description);
            Console.WriteLine("Телефон: " + _phone);
            Console.WriteLine("E-mail: " + _email);
        }
    }
}
