using System;

namespace ClassesAndRecords
{
    class Program
     {
    //     static void PrintCourse(Course course)
    //     {
    //         Console.WriteLine(course);
    //     }
        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "C# Fundamentals";
            pluralsightCourse.Author = "Scott Allen";
            pluralsightCourse.Duration = 5;
          //  PrintCourse(pluralsightCourse);

          var classroomCourse = new CourseRecord("C# Fundamentals", "Scott Allen", 5);
          
          //Nature of a record is immutable such that the below code will not compile
          //lassroomCourse.Duration = 10;
        }
    }
    public class Course
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Duration { get; set; }
    }
    //This is a declaration of a record with properties where in a class those would be parameters
    public record CourseRecord(string Name, string Author, int Duration);
}