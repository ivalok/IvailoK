using System;

namespace KamionDostavki
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapacitetKamion = 5;
            int Peralni = 0;
            int mikrofonovi = 0;
            int boileri = 0;
            Console.Write("Vuvedi broq na skladovete: ");
            int skladove = int.Parse(Console.ReadLine());
            int kursove = 0;


            for (int i = 1; i < skladove ; i++)
            {
                Console.Write($"Vuvedi 1 za peralni , 2 za mikrofonovi , 3 za boileri za sklad {i}:");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write($"Vuvedi broq na Peralni za skald {i}: ");
                    Peralni += int.Parse(Console.ReadLine());
                }
                else if (option == 2)
                {

                    Console.Write($"Vuvedi broq na miokrofonovi za skald {i}: ");
                    mikrofonovi += int.Parse(Console.ReadLine());
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
}
