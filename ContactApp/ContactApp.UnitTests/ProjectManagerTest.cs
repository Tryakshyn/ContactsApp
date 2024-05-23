using ContactsApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private string testFilePath = @"C:\Users\Андрей\Desktop\ContactApp.txt";

        [SetUp]
        public void Setup()
        {
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }
        /// <summary>
        /// Позитивный тест метода SaveFile
        /// </summary>
        [Test(Description = "Позитивный тест метода SaveFile")]
        public void SaveFile_SuccessfullySavesToFile()
        {
            var contactList = new List<Contact>
            {
            new Contact("John", "Doe", new DateTime(1990, 1, 1), new PhoneNumber("+79016070939"), "john@example.com", "john_doe"),
            new Contact("Jane", "Smith", new DateTime(1985, 5, 5), new PhoneNumber("+79016070939"), "jane@example.com", "jane_smith")
            };
            var project = new Project(contactList);

            ProjectManager.SaveFile(project);

            ClassicAssert.IsTrue(File.Exists(testFilePath));
        }
        /// <summary>
        /// Позитивный тест метода LoadFile
        /// </summary>
        [Test(Description = "Позитивный тест метода LoadFile")]
        public void LoadFile_SuccessfullyLoadFile()
        {
            var contactList = new List<Contact>
            {
            new Contact("John", "Doe", new DateTime(1990, 1, 1), new PhoneNumber("+79016070939"), "john@example.com", "john_doe"),
            new Contact("Jane", "Smith", new DateTime(1985, 5, 5), new PhoneNumber("+79016070939"), "jane@example.com", "jane_smith")
            };
            var project = new Project(contactList);
            ProjectManager.SaveFile(project);

            var loadedProject = ProjectManager.LoadFile();
            ClassicAssert.IsNotNull(loadedProject);
            ClassicAssert.AreEqual(contactList.Count, loadedProject.ContactList.Count);
        }
    }
}
