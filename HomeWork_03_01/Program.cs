using HomeWork_03_01;

Web_Site web_site = new Web_Site();
web_site.Data_Entry();

Console.WriteLine("\n\tИнформация о веб-сайте:\n");
web_site.Data_Output();

Console.WriteLine("\n\t*\t*\t*\n");

Journal journal = new Journal();
journal.Data_Entry();

Console.WriteLine("\n\tИнформация о журнале:\n");
journal.Data_Output();

Console.WriteLine("\n\t*\t*\t*\n");

Shop shop = new Shop();
shop.Data_Entry();

Console.WriteLine("\n\tИнформация о магазине:\n");
shop.Data_Output();