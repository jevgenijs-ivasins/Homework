using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public override bool Equals(object obj)
        {
            if(obj.GetType() == typeof(Student))
            {
                PropertyInfo[] properties = typeof(Student).GetProperties();
                Student originalStudent = this;
                Student compareStudent = obj as Student;

                for(int propertyIterator = 0; propertyIterator < properties.Length; propertyIterator++)
                {
                    // ToString() to compare it not by memory
                    if (properties[propertyIterator].GetValue(originalStudent).ToString() == properties[propertyIterator].GetValue(compareStudent).ToString()){
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Type { get; set; }
        public int TypeTwo { get; set; }
    }
}
