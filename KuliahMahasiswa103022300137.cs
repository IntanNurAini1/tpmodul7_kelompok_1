using System;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa103022300137
{
    public class MataKuliah
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public List<MataKuliah> courses { get; set; }

    public void ReadJSON()
    {
        string path = "tp7_2_103022300137.json";

        try
        {
            string jsonData = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<KuliahMahasiswa103022300137>(jsonData);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
