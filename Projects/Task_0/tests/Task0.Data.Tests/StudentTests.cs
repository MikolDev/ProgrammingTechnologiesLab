using NUnit.Framework;
using Task0.Data;

namespace Task0.Data.Tests
{
    [TestFixture]
    public class StudentTests
    {

        [Test]
        public void GetFullNameShouldReturnCombinedFirstAndLastName()
        {
            var student = new Student(1, "Mariusz", "Pudzianowski");

            var fullName = student.GetFullName();

            Assert.That(fullName, Is.EqualTo("Mariusz Pudzianowski"));
        }
    }
}
