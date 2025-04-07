using System;
using System.IO;
using System.Text.Json;

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

    public class DataMahasiswa103022300087
    {
        public void ReadJSON()
        {
            string filePath = "tp7_1_103022300087.json";
            string jsonData = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<Mahasiswa>(jsonData);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }