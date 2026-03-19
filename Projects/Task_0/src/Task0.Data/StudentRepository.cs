namespace Task0.Data;

using System.Collections.Generic;

public class StudentRepository : IStudentRepository
{
    private List<Student> students = new List<Student>();

    public void Save(Student student)
    {
        students.Add(student);
    }

    public int GetCount()
    {
        return students.Count;
    }
}
