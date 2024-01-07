using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03_01
{
    internal class Web_Site
    {
        private string name = string.Empty;
        private string url = string.Empty;
        private string description = string.Empty;
        private string ipAdress = string.Empty;

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public void SetUrl(string url) { this.url = url; }
        public string GetUrl() { return this.url; }
        public void SetDescription(string description) { this.description = description;}
        public string GetDescription() { return this.description;}
        public void SetIpAdress(string ipAdress) {  this.ipAdress = ipAdress;}
        public string GetIpAdress() {  return this.ipAdress; }

        public void Data_Entry()
        {
            Console.Write("Введите название сайта: ");
            name = Console.ReadLine()!;

            Console.Write("Введите путь к сайту: ");
            url = Console.ReadLine()!;

            Console.Write("Опишите о чем сайт: ");
            description = Console.ReadLine()!;

            Console.Write("Введите ip-adress: ");
            ipAdress = Console.ReadLine()!;
        }

        public void Data_Output()
        {
            Console.WriteLine("Имя сайта: " +  name);
            Console.WriteLine("Путь к сайту: " +  url);
            Console.WriteLine("Описание сайта: " + description);
            Console.WriteLine("IP - adress: " +  ipAdress);
        }

    }

}
