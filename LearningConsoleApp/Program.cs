using System;
using System.Drawing;

namespace LearningConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;

            s = new Student();
            s.Name = "Marta";
            s.Surname = "Lopez";
            s.Age = 14;
            s.Grade = 8;
            s.EyeColor = Color.Blue;
            s.School = "Stanford";
            Console.WriteLine("My new name is " + s.Name + " and I study at " + s.School);

            s = new Student();
            s.Name = "Tomass";
            s.Surname = "Vite";
            s.Age = 17;
            s.Grade = 10;
            s.EyeColor = Color.Brown;
            s.School = "Oxford";
            Console.WriteLine("My new name is " + s.Name + " and I study at " + s.School);
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
