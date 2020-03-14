using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Apliaction Calculator";
            // ini cara saya
            //int a = 10; //deklarasi data a, dengan data awal 10
            //int b = 6;  //deklarasi data b, dengan data awal 6
            A:
            Console.WriteLine("Pilihlah salah satu");
            Console.WriteLine("1. Penambahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian ");

            Console.Write("\ndipilih gan: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Inputkan data a = ");
            int a = int.Parse(Console.ReadLine()); //proses casting

            Console.Write("Inputkan data b = ");
            int b = int.Parse(Console.ReadLine()); //proses casting

            Console.WriteLine(); //tambahkan baris kosong

            if (f == 1){
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }else if (f == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (f == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (f == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else{ Console.WriteLine("\n\n Pilihan yang anda pilih tidak ada \"TOLONG ULANGI LAGI\"\n\n");
                Console.ReadKey();
                goto A;
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static double Pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
