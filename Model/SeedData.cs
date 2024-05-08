using CIS169IntroToNET.Data;
using Microsoft.EntityFrameworkCore;

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
                throw new ArgumentNullException("Null Course");
            }

            // Look for any movies.
            if (context.Course.Any())
            {
                return;   // DB has been seeded
            }

            context.Course.AddRange(
                new Course()
                {
                    CourseName = "CIS172",
                    CourseDescription = "Coding Class",
                    RoomNumber = 116,
                    StartTime = TimeOnly.Parse("9:00 AM"),
                    EndTime = TimeOnly.Parse("9:50 AM")

                },

                new Course()
                {
                    CourseName = "CIS498",
                    CourseDescription = "Coding Class",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("10:00 Am"),
                    EndTime = TimeOnly.Parse("10:50 AM")

                },

                new Course()
                {
                    CourseName = "CIS116",
                    CourseDescription = "Coding Class",
                    RoomNumber = 120,
                    StartTime = TimeOnly.Parse("11:00 Am"),
                    EndTime = TimeOnly.Parse("11:50 AM")

                },

                new Course()
                {
                    CourseName = "CIS893",
                    CourseDescription = "Coding Class",
                    RoomNumber = 224,
                    StartTime = TimeOnly.Parse("1:00 Pm"),
                    EndTime = TimeOnly.Parse("1:50 AM")

                },
                new Course()
                {
                    CourseName = "CIS120",
                    CourseDescription = "Coding Class",
                    RoomNumber = 120,
                    StartTime = TimeOnly.Parse("2:00 Pm"),
                    EndTime = TimeOnly.Parse("2:50 AM")

                }
            );
            context.SaveChanges();
        }
    }
}