using Microsoft.EntityFrameworkCore;
using CIS169IntroToNET.Data;

namespace CIS169IntroToNET.Model;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CIS169IntroToNETContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<CIS169IntroToNETContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            if (context.Course.Any())
            {
                return;
            }

            context.Course.AddRange(
                new Course
                {
                    CourseDescription = "An introduction to the php programming language.",
                    CourseName = "PHP",
                    Id = 110,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("10:10:10")
                },
                new Course
                {
                    CourseDescription = "An introduction to the C# programming language and OOP.",
                    CourseName = "C#",
                    Id = 111,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("11:10:10")
                },
                new Course
                {
                    CourseDescription = "An introduction to HTML, CSS, and Javascript",
                    CourseName = "Web Foundations",
                    Id = 112,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("12:10:10")
                },
                new Course
                {
                    CourseDescription = "An introduction to the Java programming language",
                    CourseName = "Java I",
                    Id = 113,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("13:10:10")
                },
                new Course
                {
                    CourseDescription = "The beginning to the rest of your life",
                    CourseName = "COBOL I",
                    Id = 114,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("14:10:10")
                }
            );
            context.SaveChanges();
        }
    }
}