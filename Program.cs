using System;

class Program
{
    static void Main(string[] args)
    {
        var DataAgung = new DataMahasiswa103022300087();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataAgung.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahAgung = new KuliahMahasiswa103022300087();
        KuliahAgung.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var DataIqbal = new DataMahasiswa103022300146();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahIqbal = new KuliahMahasiswa103022300146();
        KuliahIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var mahasiswa = new DataMahasiswa103022330075();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        mahasiswa.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var kuliah = new KuliahMahasiswa103022330075();
        kuliah.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var mahintan = new DataMahasiswa103022330067();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        mahintan.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var kuliahintan = new KuliahMahasiswa103022330067();
        kuliahintan.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var DataSteven = new DataMahasiswa103022300155();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahSteven = new KuliahMahasiswa103022300155();
        KuliahSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var dataGumi = new DataMahasiswa103022300137();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        dataGumi.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var kuliahGumi = new KuliahMahasiswa103022300137();
        kuliahGumi.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");

        var data = new DataMahasiswa103022300055();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        data.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var km = new KuliahMahasiswa103022300055();
        km.ReadJSON();
        Console.WriteLine("Proses selesai.\n");
        Console.WriteLine("============================================\n");
    }
}
