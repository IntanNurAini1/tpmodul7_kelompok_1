using System;

class Program
{
    static void Main(string[] args)
    {
        var DataIqbal = new DataMahasiswa103022300146();

        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.\n\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahIqbal = new KuliahMahasiswa103022300146();
        KuliahIqbal.ReadJSON();
        Console.WriteLine("Proses selesai.");
    }
}