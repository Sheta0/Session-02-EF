using Assignment_01.Contexts;
using Assignment_02.Entities;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new EF02DbContext();

            var department = new Department { Name = "CS", HiringDate = DateTime.Now };
            context.Departments.Add(department);
            context.SaveChanges();

            var instructor = new Instructor { Name = "Haerin", Bonus = 1000, Salary = 50000, Address = "Cairo", HourRate = 50, DepartmentId = department.Id };
            context.Instructors.Add(instructor);
            context.SaveChanges();


            var student01 = new Student { FName = "Ahmed", LName = "Ali", Address = "Tanta", Age = 20, DepartmentId = department.Id };
            context.Students.Add(student01);
            context.SaveChanges();

            var student02 = new Student { FName = "Mohamed", LName = "Omar", Address = "Cairo", Age = 22, DepartmentId = department.Id };
            context.Students.Add(student02);
            context.SaveChanges();

            var topic = new Topic { Name = "Programming" };
            context.Topics.Add(topic);
            context.SaveChanges();

            var course = new Course { Name = ".NET", Description = "Learn C#", Duration = 30, TopicId = topic.Id };
            context.Courses.Add(course);
            context.SaveChanges();

            var courseInst = new Course_Inst { InstructorId = instructor.InstId, CourseId = course.CrsId, evaluate = 5 };
            context.Course_Insts.Add(courseInst);
            context.SaveChanges();

            var studCourse = new Stud_Course { StudentId = student02.Id, CourseId = course.CrsId, Grade = 90 };
            context.Stud_Courses.Add(studCourse);
            context.SaveChanges();

            var students = context.Students.Select(S => new { S.FName, S.Age, S.Address });
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }

            student02.Address = "Alex";
            context.SaveChanges();


            var result = context.Students.Where(S => S.Id == 1).FirstOrDefault();
            
            context.Students.Remove(result);
            context.SaveChanges();

        }
    }
}
