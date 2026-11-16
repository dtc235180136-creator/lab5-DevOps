using System.ComponentModel.DataAnnotations;

namespace devops.Models;

public sealed class Student
{
    [Required, Display(Name = "Mã sinh viên")]
    public string StudentId { get; set; } = string.Empty;

    [Required, Display(Name = "Họ và tên")]
    public string Name { get; set; } = string.Empty;

    [Range(16, 100, ErrorMessage = "Tuổi phải nằm trong khoảng 16 đến 100.")]
    public int Age { get; set; }

    [Required, Display(Name = "Khóa")]
    public string Grade { get; set; } = string.Empty;
}
