namespace Task0.Data;
public class Student(int id, string firstname, string lastname )
{
        public int ID { get; set; } = id;
        public string FirstName { get; set; } = firstname;
        public string LastName { get; set; } = lastname;

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
}
