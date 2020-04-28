using System;

namespace PRG2_20192_P1_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("~~~~~ANAK AYAM~~~~~");
            Console.Write("\nMasukkan nilai N : ");
            int N = Convert.ToInt16(Console.ReadLine());

            if (N < 1)
            {
                Console.WriteLine("\nInput tidak boleh kurang dari 1!");
                System.Console.ReadKey();
                Main(null);
            }

            Console.WriteLine("\nANAK AYAM TURUN {0}\n", N);

            for (int i = 1; N >= i; N--)
            {
                if (N == 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", N);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", N, N - 1);
                }
            }
        }
    }
}
