using System;

    class Program
    {
        static void Main(string[] args)
        {
        DataMahasiswa103022300087 DataAgung = new DataMahasiswa103022300087();
        DataAgung.ReadJSON();
        KuliahMahasiswa103022300087 KuliahAgung = new KuliahMahasiswa103022300087();
        KuliahAgung.ReadJSON();

        var DataIqbal = new DataMahasiswa103022300146();

        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.\n\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahIqbal = new KuliahMahasiswa103022300146();
        KuliahIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.");

        var mahasiswa = new DataMahasiswa103022330075();
        mahasiswa.ReadJSON();

        var kuliah = new KuliahMahasiswa103022330075();
        kuliah.ReadJSON();

  
        var mahintan = new DataMahasiswa103022330067();
        mahintan.ReadJSON();
        Console.WriteLine();
        Console.WriteLine("====================================");
        var kuliahintan = new KuliahMahasiswa103022330067();
        kuliahintan.ReadJSON();
        Console.WriteLine("====================================");
      
        var DataSteven = new DataMahasiswa103022300155();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahSteven = new KuliahMahasiswa103022300155();
        KuliahSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        DataMahasiswa103022300055 data = new DataMahasiswa103022300055();
        data.ReadJSON();

        var km = new KuliahMahasiswa103022300055();
        km.ReadJSON();

    }
}

