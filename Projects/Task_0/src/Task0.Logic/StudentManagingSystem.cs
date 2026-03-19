namespace Task0.Logic;

using Task0.Data;
using System;

public class StudentManagingSystem(IStudentRepository repository)
{
    private readonly IStudentRepository repository = repository;

    public void AddStudent(Student student)
    {
        if (student.ID <= 0)
        {
            throw new ArgumentException("Student ID must greater than 0");
        }

        repository.Save(student);
    }

    public int GetStudenCount()
    {
        return repository.GetCount();
    }
}
