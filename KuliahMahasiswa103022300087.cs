using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
    public class KuliahMahasiswa103022300087
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
            string filePath = "tp7_2_103022300087.json";
            string jsonContent = File.ReadAllText(filePath);
            Root data = JsonSerializer.Deserialize<Root>(jsonContent);

            Console.WriteLine("Daftar mata kuliah yang diambil:");

            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
