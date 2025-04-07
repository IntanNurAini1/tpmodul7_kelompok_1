using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa103022300055
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Root
    {
        public List<Course> courses { get; set; }
    }

    public void ReadJSON()
    {
        try
        {
            string path = "tp7_2_103022300055.json"; 
            string jsonString = File.ReadAllText(path);

            Root data = JsonSerializer.Deserialize<Root>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca JSON: " + ex.Message);
        }
    }
}
