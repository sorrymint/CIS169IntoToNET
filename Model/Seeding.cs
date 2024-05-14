using CIS169IntroToNET.Data;
using Microsoft.EntityFrameworkCore;

namespace CIS169IntroToNET.Model;

public class Seeding
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
                    CourseDescription = "The logic around coding in general.",
                    CourseName = "Programming Logic",
                    Id = 100,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("09:00:00")
                },
                new Course
                {
                    CourseDescription = "Learning the beginning foundations of websites.",
                    CourseName = "Web Development",
                    Id = 101,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("08:00:00")
                },
                new Course
                {
                    CourseDescription = "An expansion on prior front-end development knowledge.",
                    CourseName = "Web Design",
                    Id = 102,
                    RoomNumber = 000,
                    StartTime = TimeOnly.Parse("00:00:00")
                },
                new Course
                {
                    CourseDescription = "The introduction to Java, one of the most popular OOL's",
                    CourseName = "Java",
                    Id = 103,
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("13:00:00")
                },
                new Course
                {
                    CourseDescription = "The introduction of utilizing the cloud for projects, and why they are needed.",
                    CourseName = "Cloud Foundations",
                    Id = 104,
                    RoomNumber = 120,
                    StartTime = TimeOnly.Parse("14:10:10")
                }
            );
            context.SaveChanges();
        }
    }
}