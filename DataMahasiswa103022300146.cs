using System;
using System.IO;
using System.Text.Json;


public class DataMahasiswa103022300146
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public Nama nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        string filePath = "tp7_1_103022300146.json";

        try
        {
            string jsonString = File.ReadAllText(filePath);
            DataMahasiswa103022300146 data = JsonSerializer.Deserialize<DataMahasiswa103022300146>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}