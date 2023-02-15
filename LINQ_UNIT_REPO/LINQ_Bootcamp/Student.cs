using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Bootcamp
{
    internal class Student
    {
        public Student(int id, string name, string surname, int age, int type, int typetwo)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Type = type;
            TypeTwo = typetwo;
        }
        public Student()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int Type { get; set; }

        public int TypeTwo { get; set; }
    }
}
