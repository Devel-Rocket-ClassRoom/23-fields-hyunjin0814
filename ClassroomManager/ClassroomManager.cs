using System;

class ClassroomManager
{
    private const int MaxStudents = 5;
    private readonly string className;
    private string[] studentNames;
    private int studentCount = 0;
    private static int classCount = 0;

    public ClassroomManager(string className)
    {
        this.className = className;
        studentNames = new string[MaxStudents];
        classCount++;
    }

    public void AddStudent(string name)
    {
        if (studentCount < MaxStudents)
        {
            studentNames[studentCount++] = name;
        }
        else
        {
            Console.WriteLine("정원 초과!");
        }
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {className} 학생 목록 ({studentCount}/{MaxStudents}) ===");
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"{i + 1}. {studentNames[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {classCount}");
    }
}
