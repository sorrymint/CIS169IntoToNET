using CIS169IntroToNET.Data;
using CIS169IntroToNET.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CIS169IntroToNET.Pages;

public class IndexModel : PageModel
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
                    CourseDescription = "This course is about C# and its many uses.",
                    CourseName = "C#",
                    Id = 998,
                    RoomNumber = 149,
                    StartTime = TimeOnly.Parse("9:38:44")
                },
                new Course
                {
                    CourseDescription = "Java is a coding language that is Object oriented learn more about java in this class",
                    CourseName = "Java",
                    Id = 490,
                    RoomNumber = 201,
                    StartTime = TimeOnly.Parse("08:45:39")
                },
                new Course
                {
                    CourseDescription = "C# but advanced",
                    CourseName = "Advanced C#",
                    RoomNumber = 177,
                    StartTime = TimeOnly.Parse("11:08:10")
                },
                new Course
                {
                    CourseDescription = "JavaScript is a very loosely typed language and is therefore hard",
                    CourseName = "JavaScript",
                    RoomNumber = 600,
                    StartTime = TimeOnly.Parse("10:27:49")
                },
                new Course
                {
                    CourseDescription = "Employability skills is a class that teaches you how to be a good employee",
                    CourseName = "Emp Skills",
                    RoomNumber = 990,
                    StartTime = TimeOnly.Parse("17:38:57")
                }
            );
            context.SaveChanges();
        }
    }
}