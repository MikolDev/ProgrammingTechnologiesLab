using NUnit.Framework;
using Task0.Logic;
using Task0.Data;
using System;

namespace Task0.Logic.Tests
{
    [TestFixture]
    public class StudentManagingSystemTests
    {
        [Test]
        public void GetStudentCount_Initially_ShouldReturnZero()
        {
            IStudentRepository repository = new StudentRepository();
            var system = new StudentManagingSystem(repository);

            Assert.That(system.GetStudentCount, Is.EqualTo(0));
        }

        [Test]
        public void AddStudentWithValidIdShouldIncreaseCount()
        {
            IStudentRepository repository = new StudentRepository();
            var system = new StudentManagingSystem(repository);
            var validStudent = new Student(8, "Stachu", "Jones");
            system.AddStudent(validStudent);

            Assert.That(system.GetStudentCount, Is.EqualTo(1));

            var validStudent2 = new Student(9, "Jan", "Kowalski");
            system.AddStudent(validStudent2);

            Assert.That(system.GetStudentCount, Is.EqualTo(2));
        }

        [Test]
        public void AddStudentWithInvalidIdShoulThrowException()
        {
            IStudentRepository repository = new StudentRepository();
            var system = new StudentManagingSystem(repository);
            var invalidStudent = new Student(-67, "Morten", "Hunke");

            Assert.Throws<ArgumentException>(() => system.AddStudent(invalidStudent));
        }
    }
}
