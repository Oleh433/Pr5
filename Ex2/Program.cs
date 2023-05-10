using System.Text;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> students = CreateStudentCollection();

            PrintExcelentStudents(students);

        }

        static Queue<Student> CreateStudentCollection()
        {
            using (StreamReader ourText = new StreamReader("data.txt", Encoding.UTF8))
            {
                Queue<Student> students = new Queue<Student>();

                while (ourText.Peek() != -1)
                {
                    students.Enqueue(new Student(ReadFileLine(ourText)));
                }

                return students;
            }
        }

        static string ReadFileLine(StreamReader text)
        {
            return text.ReadLine();
        }

        static double CountGradeAvarage(Student student)
        {
            double gradeAvarage = (CleanUpAbstention(student.MathematicsMark) +
                CleanUpAbstention(student.PhysicsMark) +
                 CleanUpAbstention(student.InformaticsMark)) / 3;

            return gradeAvarage;
        }

        static double CleanUpAbstention(char ch)
        {
            if (ch == '-')
                return 2;
            return (double)Char.GetNumericValue(ch);
        }

        static void PrintExcelentStudents(Queue<Student> students)
        {
            foreach (Student student in students)
            {
                double gradeAvarage = CountGradeAvarage(student);

                if (gradeAvarage >= 4.5)
                {
                    Console.Write($"{student.Surname} {student.FirstName} {student.Patronymic} {CleanUpAbstention(student.PhysicsMark)}");
                    Console.WriteLine();
                }
            }
        }
    }
}