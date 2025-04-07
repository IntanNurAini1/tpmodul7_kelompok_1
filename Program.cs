class Program
{
    static void Main(string[] args)
    {
        var mahasiswa = new DataMahasiswa103022330075();
        mahasiswa.ReadJSON();

        var kuliah = new KuliahMahasiswa103022330075();
        kuliah.ReadJSON();

    }
}