using System;
using System.Net.Http.Headers;
using System.Text;

namespace KamionDostavki
{
    class Program
    {
        static void Main(string[] args)   
        {
            Console.OutputEncoding = Encoding.UTF8;

            int kapacitetKamion = 5;
            int Peralni = 0;
            int mikrofonovi = 0;
            int boileri = 0;
            Console.Write("Vuvedi broq na skladovete: ");
            int skladove = int.Parse(Console.ReadLine());
            int kursove = 0;

            Product peralnqSamsung = new Product();
            peralnqSamsung.Name = "Samsung";
            peralnqSamsung.Price = 200;
            peralnqSamsung.Kiogrami = 8;
            peralnqSamsung.Capacity = 10;
            peralnqSamsung.Qty = 10;
            peralnqSamsung.Category = 1;

            Product peralnqBosh = new Product();
            peralnqBosh.Name = "Bosh";
            peralnqBosh.Price = 150;
            peralnqBosh.Kiogrami = 7;
            peralnqBosh.Capacity = 10;
            peralnqBosh.Qty = 10;
            peralnqBosh.Category = 1;

            Product peralnqAEG = new Product();
            peralnqAEG.Name = "AEG";
            peralnqAEG.Price = 100;
            peralnqAEG.Kiogrami = 6;
            peralnqAEG.Capacity = 10;
            peralnqAEG.Qty = 10;
            peralnqAEG.Category = 1;

            Product mikrofonoviSamsung = new Product();
            mikrofonoviSamsung.Name = "Samsung";
            mikrofonoviSamsung.Price = 200;
            mikrofonoviSamsung.Litri = 50;
            mikrofonoviSamsung.Capacity = 20;
            mikrofonoviSamsung.Qty = 10;
            mikrofonoviSamsung.Category = 3;

            Product mikrofonoviPhilips = new Product();
            mikrofonoviPhilips.Name = "Philips";
            mikrofonoviPhilips.Price = 150;
            mikrofonoviPhilips.Litri = 50;
            mikrofonoviPhilips.Capacity = 20;
            mikrofonoviPhilips.Qty = 10;
            mikrofonoviPhilips.Category = 3;

            Product mikrofonoviSharp = new Product();
            mikrofonoviSharp.Name = "Sharp";
            mikrofonoviSharp.Price = 100;
            mikrofonoviSharp.Litri = 50;
            mikrofonoviSharp.Capacity = 20;
            mikrofonoviSharp.Qty = 10;
            mikrofonoviSharp.Category = 3;


            Product boilerTesy = new Product();
            boilerTesy.Name = "Tesy";
            boilerTesy.Price = 200;
            boilerTesy.Litri = 80;
            boilerTesy.Capacity = 15;
            boilerTesy.Qty = 10;
            boilerTesy.Category = 2;

            Product boilerEldom = new Product();
            boilerEldom.Name = "Eldom";
            boilerEldom.Price = 150;
            boilerEldom.Litri = 50;
            boilerEldom.Capacity = 20;
            boilerEldom.Qty = 10;
            boilerEldom.Category = 2;

            Product boilerTesy50 = new Product();
            boilerTesy50.Name = "Tesy50";
            boilerTesy50.Price = 100;
            boilerTesy50.Litri = 50;
            boilerTesy50.Capacity = 10;
            boilerTesy50.Qty = 5;
            boilerTesy50.Category = 2;




            List<Product> products = new List<Product>();

            products.Add(peralnqSamsung);
            products.Add(peralnqBosh);
            products.Add(peralnqAEG);

            products.Add(boilerTesy);
            products.Add(boilerEldom);
            products.Add(boilerTesy50);

            products.Add(peralnqSamsung);
            products.Add(mikrofonoviPhilips);
            products.Add(mikrofonoviSharp);

            for (int i = 1; i < skladove ; i++)
            {
                Console.Write($"Vuvedi 1 za peralni , 2 za mikrofonovi , 3 za boileri za sklad {i}:");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write($"Vuvedi broq na Peralni za skald {i}: ");
                    Peralni += int.Parse(Console.ReadLine());

                    foreach (Product product in products)
                    {
                        if (product.Category == 1)
                        {
                            Console.Write($"Пералня: {product.Name}; ");
                        }
                    }

                    


                }
                else if (option == 2)
                {

                    Console.Write($"Vuvedi broq na miokrofonovi za skald {i}: ");
                    boileri += int.Parse(Console.ReadLine());

                    foreach (Product product in products)
                    {
                        if (product.Category == 2)
                        {
                            Console.Write($"Бойлери: {product.Name}; ");
                        }
                    }

                }
                else if (option == 3)
                {

                    Console.Write($"Vuvedi broq na boileri za skald {i}: ");
                    mikrofonovi += int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Greka!");
                }

                if (Peralni % kapacitetKamion != 0)
                {
                    kursove++;
                }

                if (mikrofonovi % (kapacitetKamion * 2) != 0)
                {
                    kursove++;
                }
                
                if (boileri % kapacitetKamion != 0)
                {
                    kursove++;
                }

            }

            
            

            Console.WriteLine($"Neobhodimi kursove: {kursove}");


        }
    }


    public class Product()
    {
        public string Name;
        public int Kiogrami;
        public int Category;
        public int Litri;
        public int Price;
        public int Capacity;
        public int Qty;


    }
}
