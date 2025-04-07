using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300055
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public void ReadJSON()
    {
        try
        {
            string path = "tp7_1_103022300055.json";
            string jsonString = File.ReadAllText(path);

            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca JSON: " + ex.Message);
        }
    }
}
