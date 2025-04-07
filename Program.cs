class Program
{
    static void Main(string[] args)
    {
        var dataGumi = new DataMahasiswa103022300137();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        dataGumi.ReadJSON();
        Console.WriteLine("Proses selesai.");

        Console.WriteLine("");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var kuliahGumi = new KuliahMahasiswa103022300137();
        kuliahGumi.ReadJSON();
        Console.WriteLine("Proses selesai.");
    }
}