using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal struct Student
    {
        public string Surname { get; }
        public string FirstName { get; }
        public string Patronymic { get; }
        public char Sex { get; }
        public string DateOfBirth { get; }
        public char MathematicsMark { get; }
        public char PhysicsMark { get; }
        public char InformaticsMark { get; }
        public int Scholarship { get; }

        public Student(string lineWithAllData)
        {
            string[] line = lineWithAllData.Split();

            Surname = line[0];
            FirstName = line[1];
            Patronymic = line[2];

            Sex = char.Parse(line[3]);

            DateOfBirth = line[4];

            MathematicsMark = char.Parse(line[5]);
            PhysicsMark = char.Parse(line[6]);
            InformaticsMark = char.Parse(line[7]);

            Scholarship = int.Parse(line[8]);
        }

    }
}
