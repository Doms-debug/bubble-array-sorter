﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_02
{
    class Program
    {

        static void Main(string[] args)
        {

            int przestrzen;
            bool sortowanie;
            int wypełnienie, liczba;
            string liczba1 = "nic";

            Random losowo = new Random();   
            

            while (!Int32.TryParse(liczba1, out wypełnienie))   
                
            {

                Console.Write("Podaj ilość liczb do posortowania: ");
                liczba1 = Console.ReadLine();

            }


            int[] tablica = new int[wypełnienie];                    
            Console.WriteLine("");

            for (int i = 0; i < wypełnienie; i++)            
            {

                liczba = losowo.Next(99);
                tablica[i] = liczba;
                Console.Write(tablica[i] + " ");     
                
            }

            Console.WriteLine("");

            for (int i = 0; i < wypełnienie - 1; i++)            
            {
                sortowanie = true;
                for (int j = 0; j < wypełnienie - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])                
                    {

                        przestrzen = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = przestrzen;
                        sortowanie = false;

                    }
                }

                if (sortowanie) break;

                Console.WriteLine();
                Console.WriteLine("Operacje: [{0}]", i + 1);        

                for (int k = 0; k < wypełnienie; k++)
                {

                    Console.Write(tablica[k] + " ");

                }
            }

            Console.WriteLine("\n");
            Console.Write("Po sortowaniu: ");             

            for (int i = 0; i < wypełnienie; i++)
            {

                Console.Write(tablica[i] + " ");

            }

            Console.Read();

        }
    }
}