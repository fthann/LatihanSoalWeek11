using System;

class Program
{

    static void TampilkanMenu()
    {
        Console.WriteLine("==== Sistem Manajemen Perpustakaan Digital SMKN Santuy Jaya ====");
        Console.WriteLine("1. Tambah Buku yu");
        Console.WriteLine("2. Tampilkan Semua Buku kawan");
        Console.WriteLine("3. Cari Buku nya der");
        Console.WriteLine("4. Keluar");
        Console.WriteLine("====");
    }

    static void Main()
    {
        while (true)
        {
            TampilkanMenu();
            Console.Write("Pilih menu Yuk: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    TambahBuku();
                    break;
                case "2":
                    TampilkanSemuaBuku();
                    break;
                case "3":
                    CariBuku();
                    break;
                case "4":
                    Console.WriteLine("Keluar dari program. Terima kasih!");
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }
        }
    }

    static string[,] rakBuku = new string[3, 2];

    static void TambahBuku()
    {
        Console.Write("Masukkan judul buku: ");
        string judul = Console.ReadLine();

        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
                if (string.IsNullOrEmpty(rakBuku[i, j])) 
                {
                    rakBuku[i, j] = judul;
                    Console.WriteLine($"Buku '{judul}' berhasil ditambahkan ke rak {i + 1}, slot {j + 1}.");
                    return;
                }
            }
        }

        Console.WriteLine("Semua rak penuh! Tidak dapat menambahkan buku.");
    }

    static void CariBuku()
    {
        Console.Write("Masukkan judul buku yang ingin dicari: ");
        string judul = Console.ReadLine();
        bool ditemukan = false;

        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
                if (rakBuku[i, j] == judul)
                {
                    Console.WriteLine($"Buku '{judul}' ditemukan di rak {i + 1}, slot {j + 1}.");
                    ditemukan = true;
                    return;
                }
            }
        }

        if (!ditemukan)
            Console.WriteLine($"Buku '{judul}' tidak ditemukan di perpustakaan.");
    }

    static void TampilkanSemuaBuku()
    {
        Console.WriteLine("== Daftar Buku di Perpustakaan SMKN Santuy Jaya ==");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Rak {i + 1}:");
            bool isRakKosong = true;

            for (int j = 0; j < 2; j++) 
            {
                if (!string.IsNullOrEmpty(rakBuku[i, j]))
                {
                    Console.WriteLine($"  - Slot {j + 1}: {rakBuku[i, j]}");
                    isRakKosong = false;
                }
            }

            if (isRakKosong)
                Console.WriteLine("  (Kosong)");
        }
    }

    
}
