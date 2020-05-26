using System;
using System.Collections.Generic;
using System.Drawing;

namespace LearningConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student());
            students[0].Name = "Marta";
            students[0].Surname = "Lopez";
            students[0].Age = 14;
            students[0].Grade = 8;
            students[0].EyeColor = Color.Blue;
            students[0].School = "Stanford";

            students.Add(new Student());
            students[1].Name = "Tomass";
            students[1].Surname = "Vite";
            students[1].Age = 17;
            students[1].Grade = 10;
            students[1].EyeColor = Color.Brown;
            students[1].School = "Oxford";

            students.Add(new Student());
            students[2].Name = "Jenifer";
            students[2].Surname = "Ozolina";
            students[2].Age = 19;
            students[2].Grade = 12;
            students[2].EyeColor = Color.Green;

            students.Add(new Student());
            students[3].Name = "Richard";
            students[3].Surname = "Clever";
            students[3].Age = 15;
            students[3].Grade = 8;
            students[3].EyeColor = Color.Blue;
            students[3].School = "Farmford";


            Console.WriteLine(students[0].Name + " studies at " + students[0].School);
            Console.WriteLine(students[1].Name + " studies at " + students[1].School);
            Console.WriteLine(students[2].Name + " studies at " + students[2].School);
            Console.WriteLine(students[3].Name + " studies at " + students[3].School);
        }
    }
    

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public Color EyeColor { get; set; }
        public string School { get; set; } = "Datorium";
        public Student()
        {
            Console.WriteLine("Hi, I am a new student with no name and I study at " + this.School);
        }
    }
}
