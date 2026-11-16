using devops.Models;

namespace devops.Services;

public sealed class StudentStore
{
    private readonly List<Student> students =
    [
        new() { StudentId = "SV001", Name = "Nguyễn Văn An", Age = 20, Grade = "K20" },
        new() { StudentId = "SV002", Name = "Trần Thị Bình", Age = 21, Grade = "K20" },
        new() { StudentId = "SV003", Name = "Lê Văn Cường", Age = 19, Grade = "K21" }
    ];

    public IReadOnlyList<Student> Search(string? keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return students;
        }

        return students
            .Where(student => student.StudentId.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || student.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || student.Grade.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public bool Add(Student student)
    {
        if (students.Any(item => item.StudentId.Equals(student.StudentId, StringComparison.OrdinalIgnoreCase)))
        {
            return false;
        }

        students.Add(student);
        return true;
    }
}
