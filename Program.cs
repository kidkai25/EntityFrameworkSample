using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFV4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFContext())
            {
                //Sample Data
                //Department department = new Department { Name = "History" };
                //Department department2 = new Department { Name = "Maths" };
                //context.Departments.Add(department);
                //context.Departments.Add(department2);

                Course course = new Course { Title = "beginer", DepartmentID = 1 };
                Course course2 = new Course { Title = "intermediate", DepartmentID = 1 };
                Course course3 = new Course { Title = "expert", DepartmentID = 2 };

                context.Courses.Add(course);
                context.Courses.Add(course2);
                context.Courses.Add(course3);



                context.SaveChanges();

                Console.WriteLine("Done");
                Console.ReadKey();

                //Course course = new Course { Credits = 10, }
            }
        }
    }
}
