using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022330075
{
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public void ReadJSON()
    {
        string path = "tp7_1_103022330075.json";

        try
        {
            string jsonData = File.ReadAllText(path);
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonData);
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi kesalahan saat membaca file JSON:");
            Console.WriteLine(e.Message);
        }
    }
}
