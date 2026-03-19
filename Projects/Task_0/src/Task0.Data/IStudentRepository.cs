namespace Task0.Data
{
    public interface IStudentRepository
    {
        int GetCount();
        void Save(Student student);
    }
}