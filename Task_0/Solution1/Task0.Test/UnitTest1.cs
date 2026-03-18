using Task0.Logic;
using NUnit.Framework;
namespace Task0.Test;
public class Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentStoredProperties()
        {
            var s1 = new Student(2323, "Maciek", "Kubek");
            var s2 = new Student(997, "Kuba", "Hubba Bubba");

            Assert.That(s1.FirstName, Is.EqualTo("Maciek"));
            Assert.That(s1.LastName, Is.EqualTo("Kubek"));
            Assert.That(s1.ID, Is.EqualTo(2323));

            Assert.That(s1.FirstName, Is.Not.EqualTo(s2.FirstName));
            Assert.That(s1.LastName, Is.Not.EqualTo(s2.FirstName));
            Assert.That(s1.ID, Is.Not.EqualTo(s2.ID));
        }

        [Test]
        public void GetFullNameReturnsCorrectFullName()
        {
            var student = new Student(67, "Mariusz", "Pudzianowski");
            var fullName = student.GetFullName();

            Assert.That(fullName, Is.EqualTo("Mariusz Pudzianowski"));
        }
        

    }
}
