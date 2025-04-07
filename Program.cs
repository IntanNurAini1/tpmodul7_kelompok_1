class Program
{
    static void Main(string[] args)
    {
      
        var DataSteven = new DataMahasiswa103022300155();
        Console.WriteLine("Memulai proses membaca data mahasiswa...");
        DataSteven.ReadJSON();
        Console.WriteLine("Proses selesai.\n");

        Console.WriteLine("Memulai proses membaca data mata kuliah...");
        var KuliahSteven = new KuliahMahasiswa103022300155();
        KuliahSteven.ReadJSON();
        Console.WriteLine("Proses selesai.");

        DataMahasiswa103022300055 data = new DataMahasiswa103022300055();
        data.ReadJSON();

        var km = new KuliahMahasiswa103022300055();
        km.ReadJSON();

    }
}