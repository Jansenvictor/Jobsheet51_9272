const int biayaAdministrasi = 2000;

        Console.Write("Nama pelanggan   : ");
        string namaPelanggan = Console.ReadLine();


        Console.Write("Nama Dokumen   : ");
        string NamaDokumen = Console.ReadLine();

        Console.Write("Jumlah halaman   : ");
        int jumlahHalaman = int.Parse(Console.ReadLine());

        Console.Write("Harga per halaman: ");
        int hargaPerHalaman = int.Parse(Console.ReadLine());

        int subtotal = jumlahHalaman * hargaPerHalaman;
        int totalBayar = subtotal + biayaAdministrasi;

    
        Console.WriteLine();
        Console.WriteLine("= RINCIAN PENCETAKAN =");
        Console.WriteLine("Nama pelanggan = " + namaPelanggan);
        Console.WriteLine("Nama dokumen = " + NamaDokumen);
        Console.WriteLine("Jumlah halaman = " + jumlahHalaman);
        Console.WriteLine("Harga per halaman = " + hargaPerHalaman);
        Console.WriteLine("Subtotal = " + subtotal);
        Console.WriteLine("Biaya administrasi = " + biayaAdministrasi);
        Console.WriteLine("Total bayar = " + totalBayar);