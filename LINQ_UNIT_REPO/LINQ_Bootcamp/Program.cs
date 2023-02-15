using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_Bootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Student> students = new List<Student>();
            //students.Add(new Student(0, "Jevgenijs", "Ivashins", 22, 1, 10));
            //students.Add(new Student(1, "Sofja", "Ytrewq", 20, 3, 12));
            //students.Add(new Student(2, "Andis", "dasf", 23, 3, 15));
            //students.Add(new Student(3, "Raitis", "dsafax", 21, 1, 22));
            //students.Add(new Student(4, "Arturs", "dfqas", 21, 2, 11));
            //students.Add(new Student(5, "Daniils", "dsafax", 20, 2, 34));
            //students.Add(new Student(6, "Kristaps", "dfqas", 21, 1, 15));
            //students.Add(new Student(7, "Pavels", "dfqas", 21, 2, 5));

            //List<Type> types = new List<Type>();
            //types.Add(new Type() { Id = 1, Name = "Front-end" });
            //types.Add(new Type() { Id = 2, Name = "Back-end" });
            //types.Add(new Type() { Id = 3, Name = "Full-stack" });

            #region Task 1
            // #### TASK 1 ####
            //var studentNames = students.Select(x => x.Name ).ToList();

            //var studentNames = (from student in students
            //                    select student.Name).ToList();
            #endregion
            #region Task 2

            //var studentsAdult = students.Where(student => student.Age >= 18).ToList();

            //var studentsAdult = (from student in students
            //                    where student.Age >= 18
            //                    select student).ToList();

            #endregion
            #region Task3

            //var studentsList = students.OrderBy(x => x.Name).ToList();

            //var studentsList = (from student in students
            //                     orderby student.Name
            //                     select student).ToList();

            #endregion
            #region Task4

            // var studentsList = students.OrderBy(student => student.Name).ThenBy(student => student.Age).ToList();

            //var studentsList = (from student in students
            //                    orderby student.Name, student.Age
            //                    select student).ToList();

            #endregion
            #region Task5

            //var orderedStudents = students.GroupBy(student => student.Type).ToList();

            //var orderedStudents = from studentGroup in students
            //                      group studentGroup by studentGroup.Type;

            #endregion
            #region Task6
            //var studentsGroup = students.GroupBy(student => new { Type = student.Type, TypeTwo = student.TypeTwo})
            #endregion
            #region Task7
            //var studentTypeGroup = students.Join(
            //                       types,
            //                       student => student.Type,
            //                       type => type.Id,
            //                       (student, type) => new
            //                            {
            //                                StudentName = student.Name,
            //                                TypeName = type.Name
            //                            });

            //var studentTypeGroup = from student in students
            //                       join type in types on student.Type equals type.Id
            //                       select new { StudentName = student.Name, TypeName = type.Name };
            #endregion
            #region Task8

            //bool isOneUSAdult = students.Any(student => student.Age >= 21);

            #endregion
            #region Task9
            // Student student = new Student() { Id = 8, Name = "Mihails", Surname = "asdad", Age = 14, Type = 2, TypeTwo = 15 };
            //// Student student = new Student(8, "Mihails", "adsd", 14, 2, 15);
            // students.Add(student);
            // bool doContain = students.Contains(student);
            #endregion
            #region Classwork stuff
            //studentsList.ForEach(student => Console.WriteLine(student.Name + " " + student.Age));

            //foreach (var pair in studentTypeGroup)
            //{
            //    Console.WriteLine("{0} - {1}", pair.StudentName, pair.TypeName);
            //}

            //Console.WriteLine(doContain);
            #endregion

            #region Homework

            List<HomeworkClass> homeworkGroup = new List<HomeworkClass>();
            HomeworkClass homework = new HomeworkClass() { Id = 1 };
            homeworkGroup.Add(homework);
            HomeworkClass homework2 = new HomeworkClass() { Id = 1 };
            Console.WriteLine(homeworkGroup.Contains(homework2));
            Console.ReadLine();

            #endregion
        }
       
    }

    public class List<T>
    {

        public T[] generalList = new T[0];

        public void Add(T newObj)
        {
            T[] tempList = generalList;
            generalList = new T[generalList.Length + 1];
            for(int i = 0; i < generalList.Length; i++)
            {
                // -1 to access array's last element
                if(i == generalList.Length - 1)
                {
                    generalList[i] = newObj;
                    break;
                }
                generalList[i] = tempList[i];
            }
        }

        // It's ugly but achieves the task
        public bool Contains(T compareObj)
        {
            HomeworkClass homeworkCompare = new HomeworkClass();
            if(compareObj.GetType() == typeof(HomeworkClass))
            {
                homeworkCompare = compareObj as HomeworkClass;
            }

            foreach(T iteratableObj in generalList)
            {
                if(iteratableObj.GetType() == typeof(HomeworkClass))
                {
                    HomeworkClass homeworkIteratable = iteratableObj as HomeworkClass;
                    if (homeworkIteratable.Id == homeworkCompare.Id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
