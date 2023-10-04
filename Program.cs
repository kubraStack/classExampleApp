using System;

namespace classUygulama
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public string desc { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Product class = name, price, description
           // Sınırsız sayıda ürün bilgisini alıp bir dizi içerisinde saklayınız
           // Ürün adetini kullanıcı belirtsin
           // Eklenen ürünler listelensin
           System.Console.Write("Ürün sayısı: ");
           int adet = int.Parse(Console.ReadLine());

           Product[] products = new Product[adet];

           int i = 0;
           Product prd;
        
           do
           {
                prd = new Product();

                System.Console.Write("Ürün Adı: ");
                prd.name = Console.ReadLine();

                System.Console.Write("Ürün Fiyatı: ");
                prd.price = double.Parse(Console.ReadLine());

                System.Console.Write("Ürün Açıklaması: ");
                prd.desc = Console.ReadLine();
                
                products[i] = prd;
                i++;

            
           } while (adet > i);

           System.Console.WriteLine("***********");

            //    for (int a = 0; a < products.Length; a++)
            //    {
            //     System.Console.WriteLine($"ürün adı: {products[a].name}, ürün fiyatı: {products[a].price}, ürün desc: {products[a].desc}");
            //    }

            foreach (var p in products)
            {
               System.Console.WriteLine($"ürün adı: {p.name}, ürün fiyatı: {p.price}, ürün desc: {p.desc}");

            }
        }
    }
}
