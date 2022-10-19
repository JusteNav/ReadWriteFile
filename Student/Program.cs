namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var student = JsonHelper.LoadStudent();

            Console.WriteLine($"Student name: {student.Name}");

            var newStudent = new Student
            {
                Id = 101,
                Name = "Bilbo",
                Surname = "Baggins",
                Grades = new int[] { 8, 5, 9, 9, 7, 10 }
            };

            JsonHelper.SaveStudent(newStudent);
            var loadedNewStudent = JsonHelper.LoadStudent();

            Console.WriteLine($"New student name: {loadedNewStudent.Name}");
        }
    }
}