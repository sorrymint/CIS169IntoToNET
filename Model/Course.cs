using System.ComponentModel.DataAnnotations;

namespace CIS169IntroToNET.Model;

public class Course
{
    public int Id { get; set; }
    public string? CourseName { get; set; }
    public string? CourseDescription { get; set; }
    public int RoomNumber { get; set; }

    [DataType(DataType.Time)] public TimeOnly StartTime { get; set; }
}