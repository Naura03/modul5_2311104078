<<<<<<< HEAD
﻿using modul5_2311104078;

class Program
{
    static void Main()
    {
        int num1 = 23; // Dua digit dari NIM
        int num2 = 11;
        int num3 = 04;

        int hasil = Penjumlahan.JumlahTigaAngka(num1, num2, num3);
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");
=======
﻿class Program
{
    static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(23);
        db.AddNewData(11);
        db.AddNewData(04);

        db.PrintAllData();
>>>>>>> implementasi-generic-class
    }
}