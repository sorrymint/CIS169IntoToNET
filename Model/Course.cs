using System.ComponentModel.DataAnnotations;

namespace CIS169IntroToNET.Model;

public class Course
{
    public int Id { get; set; }
    public string? CourseName { get; set; }
    [Display(Name = "Course Name")]
    public string? CourseDescription { get; set; }
    [Display(Name = "Course Description")]
    public int RoomNumber { get; set; }
    [Display(Name = "Room Number")]

    [DataType(DataType.Time)] public TimeOnly StartTime { get; set; }
    [DataType(DataType.Time)] public TimeOnly EndTime { get; set; }
}