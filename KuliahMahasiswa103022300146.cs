using System;
using System.IO;
using System.Text.Json;

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class KuliahMahasiswa103022300146
{
    public Course[] courses { get; set; }

    public void ReadJSON()
    {
        string filePath = "tp7_2_103022300146.json";

        try
        {
            string jsonString = File.ReadAllText(filePath);
            KuliahMahasiswa103022300146 data = JsonSerializer.Deserialize<KuliahMahasiswa103022300146>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.courses.Length; i++)
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