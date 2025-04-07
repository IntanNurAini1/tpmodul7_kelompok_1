class Program
{
    static void Main()
    {
        var mahintan = new DataMahasiswa103022330067();
        mahintan.ReadJSON();
        Console.WriteLine();
        Console.WriteLine("====================================");
        var kuliahintan = new KuliahMahasiswa103022330067();
        kuliahintan.ReadJSON();
        Console.WriteLine("====================================");
    }
}
