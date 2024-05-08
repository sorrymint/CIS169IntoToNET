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
                    CourseDescription = "Learn the little brother of Java",
                    CourseName = "C#",
                    Id = 123,
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("03-16-2024")
                },
                new Course
                {
                    CourseDescription = "Java is supreme",
                    CourseName = "Java",
                    Id = 456,
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("06-12-2024")
                },
                new Course
                {
                    CourseDescription = "JavaScript is exists to teach us why we shouldn't make a language in a week",
                    CourseName = "JavaScript",
                    RoomNumber = 118,
                    StartTime = TimeOnly.Parse("04-20-2024")
                },
                new Course
                {
                    CourseDescription = ".NET is a framework, I guess",
                    CourseName = "Advanced C#",
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("08-12-2024")
                },
                new Course
                {
                    CourseDescription = "COBOL is the bane of this world and should be obliterated... just kidding, don't kill me susan!",
                    CourseName = "COBOL",
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("07-13-2024")
                }
            );
            context.SaveChanges();
        }
    }
}