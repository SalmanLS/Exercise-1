using System;

namespace Exercise
{
    class Program
    {
        private int[] SLS = new int[29];
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
    }
}