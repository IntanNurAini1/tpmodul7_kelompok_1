class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300055 data = new DataMahasiswa103022300055();
        data.ReadJSON();

        var km = new KuliahMahasiswa103022300055();
        km.ReadJSON();
    }
}