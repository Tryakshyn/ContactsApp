using ContactsApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        /// <summary>
        /// Позитивный тест геттера ContactList
        /// </summary>
        [Test(Description = "Позитивный тест геттера ContactList")]
        public void TestContactListGet_CorrectValue()
        {
            var expected = new List<Contact>
            {
            new Contact("John", "Doe", new DateTime(1990, 5, 15), new PhoneNumber("+79060909393"), "john.doe@example.com", "johndoe123"),
            new Contact("Alice", "Smith", new DateTime(1985, 8, 25), new PhoneNumber("+79060909393"), "alice.smith@example.com", "alicesmith456"),
            new Contact("Bob", "Johnson", new DateTime(1980, 3, 10), new PhoneNumber("+79060909393"), "bob.johnson@example.com", "bobjohnson789")
            };
            var project = new Project(expected);
            project.ContactList = expected;
            var actual = project.ContactList;

            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера ContactList");
        }
        /// <summary>
        /// Позитивный тест cеттера ContactList
        /// </summary>
        [Test(Description = "Позитивный тест сеттера ContactList")]
        public void TestContactListSet_CorrectValue()
        {
            var initialContacts = new List<Contact>
            {
            new Contact("John", "Doe", new DateTime(1990, 5, 15), new PhoneNumber("+79060909393"), "john.doe@example.com", "johndoe123")
            };
            var project = new Project(initialContacts);

            var expected = new List<Contact>
            {
            new Contact("Alice", "Smith", new DateTime(1985, 8, 25), new PhoneNumber("+79060909393"), "alice.smith@example.com", "alicesmith456"),
            new Contact("Bob", "Johnson", new DateTime(1980, 3, 10), new PhoneNumber("+79060909393"), "bob.johnson@example.com", "bobjohnson789")
            };

            project.ContactList = expected;

            var actual = project.ContactList;

            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера ContactList");
        }
    }
}
