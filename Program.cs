using System;

    class Program
    {
        static void Main(string[] args)
        {
        DataMahasiswa103022300087 DataAgung = new DataMahasiswa103022300087();
        DataAgung.ReadJSON();
        KuliahMahasiswa103022300087 KuliahAgung = new KuliahMahasiswa103022300087();
        KuliahAgung.ReadJSON();
        }
    }

