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
                throw new ArgumentNullException("Null CIS169IntroToNETContext");
            }

            if (context.Course.Any())
            {
                return; // DB has been seeded
            }

            context.Course.AddRange(
                new Course
                {
                    Id = 12,
                    CourseDescription = "Epic Course for cool Stuff",
                    CourseName = "Epic Programming",
                    RoomNumber = 127,
                    StartTime = new TimeOnly(8, 0),
                    EndTime = new TimeOnly(9,0)
                },
                new Course
                {
                    Id = 05,
                    CourseDescription = "Super Hard, Not For Smooth Brains",
                    CourseName = "Putting Blocks Through Hols",
                    RoomNumber = 02,
                    StartTime = new TimeOnly(12, 15),
                    EndTime = new TimeOnly(13,15)
                },
                new Course
                {
                    Id = 10,
                    CourseDescription = "ZZzzZZ",
                    CourseName = "Nap Time",
                    RoomNumber = 255,
                    StartTime = new TimeOnly(15, 30),
                    EndTime = new TimeOnly(16, 30)
                },
                new Course
                {
                    Id = 22,
                    CourseDescription = "Introduction To Cool New Things",
                    CourseName = "Learn",
                    RoomNumber = 22,
                    StartTime = new TimeOnly(10, 15),
                    EndTime = new TimeOnly(11,15)
                },
                new Course
                {
                    Id = 60,
                    CourseDescription = "Super Epic Swag",
                    CourseName = "C#",
                    RoomNumber = 200,
                    StartTime = new TimeOnly(10, 50),
                    EndTime = new TimeOnly(11, 50)
                }
            );
            context.SaveChanges();
        }
    }
}