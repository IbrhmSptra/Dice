using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Dadu = new int [1];
            int A;
            do{
                Console.WriteLine("Berapa Dadu yang anda butuhkan?");
                System.Console.WriteLine("1 Buah Dadu");
                System.Console.WriteLine("2 Buah Dadu");
                System.Console.WriteLine("                       Press 3 For Exit Program");
                System.Console.Write("Enter Number . . .");
                Dadu[0] = Convert.ToInt32(Console.ReadLine());
                    switch (Dadu[0]) {
                        case 1:
                        do {
                        Random Dadu1 = new Random();
                        int Hasil1 = Dadu1.Next(1 , 7);
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------------------------------");
                        System.Console.WriteLine("Anda Mendapatkan Angka =" +Hasil1);
                        System.Console.WriteLine("----------------------------------");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        do {
                            System.Console.WriteLine("1.Acak Dadu Lagi                                                 2.Back");
                            System.Console.Write("Enter Number Here...");
                            A = Convert.ToInt32(Console.ReadLine());
                            System.Console.WriteLine();
                            if (A!=1 && A!=2) {
                                System.Console.WriteLine("****************************");
                                System.Console.WriteLine("Maaf Pilihan Tidak Tersedia!");
                                System.Console.WriteLine("****************************");
                                System.Console.WriteLine();
                            }
                        }while (A!=1 && A!=2);
                    }while (A!=2);
                    break;
                    case 2 :
                    do {
                        Random Dadu2 = new Random ();
                        int n = 2;
                        for (n=1;n<=2;n++) {
                        int Hasil2 = Dadu2.Next(1 , 7);
                        System.Console.WriteLine("----------------------------------");
                        System.Console.WriteLine("Anda Mendapatkan Angka =" +Hasil2);
                        System.Console.WriteLine("----------------------------------");
                        System.Console.WriteLine();
                    }
                    do {
                        System.Console.WriteLine("1.Acak Dadu Lagi                                                 2.Back");
                        System.Console.Write("Enter Number Here...");
                        A = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine();
                        if (A!=1 && A!=2) {
                                System.Console.WriteLine("****************************");
                                System.Console.WriteLine("Maaf Pilihan Tidak Tersedia!");
                                System.Console.WriteLine("****************************");
                                System.Console.WriteLine();
                            }
                        }while (A!=1 && A!=2);
                    }while (A!=2);
                    break;
                    default :
                        System.Console.WriteLine();
                        System.Console.WriteLine("****************************");
                        System.Console.WriteLine("Maaf Pilihan Tidak Tersedia!");
                        System.Console.WriteLine("****************************");
                        System.Console.WriteLine();
                    break;
                }
            }while (Dadu[0] !=3);
            System.Console.WriteLine();
            System.Console.WriteLine("--------------------------------------------------------------------------------");
            System.Console.WriteLine("Terimakasih Telah Menggunakan Program Dadu Ini Semoga Permainanmu Menyenangkan!");
            System.Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Beep();
        }
    }
}