using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ditt medelande");
            string medelande = Console.ReadLine();
            Console.WriteLine("Hur långt åt vänster vill du flytta medelandet.");
            string steg = Console.ReadLine();

            int flyttning = int.Parse(steg);

            for (int i=0; i<medelande.Length; i++)
            {
                for (int j = 0; j < flyttning; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(medelande[i]);
            }  

        }
    }
}
