using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        private int[] luthfi = new int[29];
        private int n;

        public void Read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 29)
                    break;
                else
                    Console.WriteLine("\n Maksimal elemen pada array adalah 29 \n");

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Masukkan elemen array ke{i+1} :");
                string s2 = Console.ReadLine();
                luthfi[i] = int.Parse(s2);
            }
        }

        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("********************************");
            Console.WriteLine("Elemen Array yang telah tersusun");
            Console.WriteLine("********************************");
            for (int sls = 0; sls < n; sls++)
            {
                Console.WriteLine(luthfi[sls]);
            }
            Console.WriteLine("");
        }

        public void InsertionsSort()
        {
            int k = luthfi[0];
            for (int i = 1; i < n; i++)
            {
                for (int sls = 1; sls < n; sls++)
                {
                    if (luthfi[i] < k)
                    {
                        k = luthfi[i];
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