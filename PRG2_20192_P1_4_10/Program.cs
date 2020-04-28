using System;

namespace PRG2_20192_P1_4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("***** MENU SEGITIGA SIKU-SIKU *****");
            Console.WriteLine("\na. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");
            Console.Write("\nMenu pilihan : ");
            char pilihan = Convert.ToChar(Console.ReadLine());

            switch (pilihan)
            {
                case 'a':
                    Console.Clear();
                    Console.WriteLine("===== MENGHITUNG LUAS SEGITIGA =====");
                    Console.Write("\nMasukkan alas segitiga : ");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi segitiga : ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());

                    double luas = alas * tinggi / 2;
                    
                    Console.WriteLine("\nLuas segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah {2:0.00} satuan", alas, tinggi, luas);

                    Console.Write("\nIngin coba lagi ? (y/t) : ");
                    char jawab = Convert.ToChar(Console.ReadLine());

                    switch(jawab)
                    {
                        case 'y':
                            Main(null);
                            break;
                        case 'Y':
                            Main(null);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 'b':
                    Console.Clear();
                    Console.WriteLine("===== MENCARI HIPOTENUSA SSEGITIGA =====");
                    Console.Write("\nMasukkan sisi A segitiga : ");
                    double sisiA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan sisi B segitiga : ");
                    double sisiB = Convert.ToDouble(Console.ReadLine());

                    double hipotenusa = Math.Sqrt(Math.Pow(sisiA, 2) + Math.Pow(sisiB, 2));

                    Console.WriteLine("\nHipotenusa segitiga dengan sisi A {0:0.00} dan sisi B {1:0.00} adalah {2:0.00}", sisiA, sisiB, hipotenusa);
                    Console.Write("\nIngin coba lagi ? (y/t) : ");
                    jawab = Convert.ToChar(Console.ReadLine());

                    switch (jawab)
                    {
                        case 'y':
                            Main(null);
                            break;
                        case 'Y':
                            Main(null);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 'c':
                    Console.Clear();
                    Console.WriteLine("===== MENGHITUNG KELILING SEGITIGA =====");
                    Console.Write("\nMasukkan sisi A segitiga : ");
                    sisiA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan sisi B segitiga : ");
                    sisiB = Convert.ToDouble(Console.ReadLine());

                    hipotenusa = Math.Sqrt(Math.Pow(sisiA, 2) + Math.Pow(sisiB, 2));

                    double keliling = sisiA + sisiB + hipotenusa;

                    Console.WriteLine("\nKeliling segitiga dengan sisiA {0:0.00} dan sisiB {1:0.00} dan sisiC {2:0.00} adalah {3:0.00}", sisiA, sisiB, hipotenusa, keliling);
                    Console.Write("\nIngin coba lagi ? (y/t) : ");
                    jawab = Convert.ToChar(Console.ReadLine());

                    switch (jawab)
                    {
                        case 'y':
                            Main(null);
                            break;
                        case 'Y':
                            Main(null);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 'd':
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
