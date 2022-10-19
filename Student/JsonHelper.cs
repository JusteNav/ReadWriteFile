using System.Text.Json;
using System.Text.Json.Serialization;

namespace Student
{
    internal class JsonHelper
    {

        private readonly static string _filePathStudent = @"../../../../Student/Student.json";

        public static Student LoadStudent()
        {
            var jsonString = File.ReadAllText(_filePathStudent);
            var student = JsonSerializer.Deserialize<Student>(jsonString);
            return student;
        }

        public static void SaveStudent(Student student)
        {
            string jsonString = JsonSerializer.Serialize(student);
            File.WriteAllText(_filePathStudent, jsonString);
        }
    }
}
