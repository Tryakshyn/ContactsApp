using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp;
using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }
        /// <summary>
        /// Позитивный тест геттера FirstName
        /// </summary>
        [Test(Description = "Позитивный тест геттера FirstName")]
        public void TestFirstNameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.LastName = expected;
            var actual = _contact.LastName;
            Assert.That(actual,Is.EqualTo(expected), "Позитивный тест геттера FirstName");
        }
        /// <summary>
        /// Позитивный тест cеттера FirstName
        /// </summary>
        [Test(Description = "Позитивный тест cеттера FirstName")]
        public void TestFirstNameSet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.LastName = expected;
            var actual = _contact.LastName;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера FirstName");
        }
        /// <summary>
        /// Негативный тест cеттера FirstName
        /// </summary>
        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
        TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если имя длиннее 50 символов",
        TestName = "Присвоение неправильного имени большего 50 символов")]
        public void TestFirstNameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.FirstName = wrongSurname; }, message);
        }
        /// <summary>
        /// Позитивный тест геттера LastName
        /// </summary>
        [Test(Description = "Позитивный тест геттера LastName")]
        public void TestLastNameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.LastName = expected;
            var actual = _contact.LastName;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера LastName");
        }
        /// <summary>
        /// Позитивный тест геттера LastName
        /// </summary>
        [Test(Description = "Позитивный тест сеттера LastName")]
        public void TestLastNameSet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.LastName = expected;
            var actual = _contact.LastName;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера LastName");
        }
        /// <summary>
        /// Негативный тест сеттера LastName
        /// </summary>
        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
        TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если фамилия длиннее 50 символов",
        TestName = "Присвоение неправильной фамилии большей 50 символов")]
        public void TestLastNameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.LastName = wrongSurname; }, message);
        }
        /// <summary>
        /// Позитивный тест геттера Birthday
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday")]
        public void TestBirthdayGet_CorrectValue()
        {
            DateTime expected = new DateTime(2003,10,5);
            _contact.Birthday = expected;
            DateTime actual = _contact.Birthday;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера Birthday");
        }
        /// <summary>
        /// Позитивный тест сеттера Birthday
        /// </summary>
        [Test(Description = "Позитивный тест сеттера Birthday")]
        public void TestBirthdaySet_CorrectValue()
        {
            DateTime expected = new DateTime(2003, 10, 5);
            _contact.Birthday = expected;
            DateTime actual = _contact.Birthday;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера Birthday");
        }
        [TestCase("1899,1,1", "Должно возникать исключение, если дата рождения меньше 1900 года",
        TestName = "Присвоение неправильной даты рождения меньшей 1900 года")]
        public void TestBirthdaySet_ArgumentException(DateTime wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.Birthday = wrongSurname; }, message);
        }
        /// <summary>
        /// Позитивный тест геттера phoneNumber
        /// </summary>
        [Test(Description = "Позитивный тест геттера phoneNumber")]
        public void TestphoneNumberGet_CorrectValue()
        {
            PhoneNumber expected = new PhoneNumber("+79016070939");
            _contact.phoneNumber = expected;
            PhoneNumber actual = _contact.phoneNumber;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера phoneNumber");
        }
        /// <summary>
        /// Позитивный тест геттера phoneNumber
        /// </summary>
        [Test(Description = "Позитивный тест сеттера phoneNumber")]
        public void TestphoneNumberSet_CorrectValue()
        {
            PhoneNumber expected = new PhoneNumber("+79016070939");
            _contact.phoneNumber = expected;
            PhoneNumber actual = _contact.phoneNumber;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера phoneNumber");
        }
        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "andrey@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера Email");
        }
        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestEmailSet_CorrectValue()
        {
            var expected = "andrey@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера Email");
        }
        /// <summary>
        /// Негативный тест сеттера Email
        /// </summary>
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если электронная почта длиннее 50 символов",
        TestName = "Присвоение неправильной электронной почты большего 50 символов")]
        [TestCase("SMIRNOVE", "Должно возникать исключение, если электронная почта не содержит символ @",
        TestName = "Присвоение неправильной электронной почты без обязательного символа @")]
        public void TestEmailSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.Email = wrongSurname; }, message);
        }
        /// <summary>
        /// Позитивный тест геттера VkId
        /// </summary
        [Test(Description = "Позитивный тест геттера VkId")]
        public void TestVkIdGet_CorrectValue()
        {
            var expected = "idsmirnov";
            _contact.VkId = expected;
            var actual = _contact.VkId;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера VkId");
        }
        /// <summary>
        /// Позитивный тест геттера VkId
        /// </summary
        [Test(Description = "Позитивный тест сеттера VkId")]
        public void TestVkIdSet_CorrectValue()
        {
            var expected = "idsmirnov";
            _contact.VkId = expected;
            var actual = _contact.VkId;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера VkId");
        }
        /// <summary>
        /// Негативный тест сеттера VkId
        /// </summary>
        [TestCase("smirnove-smirnove-smirnove", "Должно возникать исключение, если VkId длиннее 15 символов",
        TestName = "Присвоение неправильного VkId большего 15 символов")]
        public void TestVkIdSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.VkId = wrongSurname; }, message);
        }
    }
}
