using System;
using System.Globalization;

namespace Exercise
{
    class Program //Membuat class program
    {
        private int[] luthfi = new int[29]; //deklarasi array beserta maksimum datanya
        private int n; // deklarasi variabel untuk mengisi data

        public void Read() //fungsi untuk menerima masukkan
        {
            while (true) // untuk memastikan bahwa data tidak melebihi nilai maksimun
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 29)
                    break;
                else
                    Console.WriteLine("\n Maksimal elemen pada array adalah 29 \n");

            }
            for (int i = 0; i < n; i++) //looping untuk memasukkan data
            {
                Console.Write($"Masukkan elemen array ke {i+1} :");
                string s2 = Console.ReadLine();
                luthfi[i] = int.Parse(s2);
            }
        }

        public void display() //fungsi untuk memunculkan hasil yang telah diurutkan
        {
            Console.WriteLine("");
            Console.WriteLine("********************************");
            Console.WriteLine("Elemen Array yang telah tersusun");
            Console.WriteLine("********************************");
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(luthfi[i]);
            }
            Console.WriteLine("");
        }

        public void InsertionsSort() //fungsi untuk mengurutkan angka dari data-data didalam array
        {
            for (int i = 0; i < (n-2); i++)
            {
                for (int sls = 0; sls < n; sls++)
                {
                    if (luthfi[0] < luthfi[sls+1])
                    {
                        int temp;
                        temp = luthfi[sls];
                        luthfi[sls] = luthfi[0]; 
                        luthfi[0] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program kerja = new Program();
            kerja.Read();
            kerja.InsertionsSort();
            kerja.display();
        }
    }
}