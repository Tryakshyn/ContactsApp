using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        /// <summary>
        /// Позитивный тест геттера Number
        /// </summary>
        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = "+79016070939";
            PhoneNumber phoneNumber = new PhoneNumber(expected);
            phoneNumber.Number = expected;
            var actual = phoneNumber.Number;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест геттера Number");
        }
        /// <summary>
        /// Негативный тест cеттера Number
        /// </summary>
        [TestCase("", "Должно возникать исключение, если номер телефона - пустая строка",
        TestName = "Присвоение пустой строки в качестве номера телефона")]
        [TestCase("89015325345332", "Должно возникать исключение, если номер телефона длиннее 12 символов",
        TestName = "Присвоение неправильного номера телефона большего 12 символов")]
        [TestCase("+89016070939", "Должно возникать исключение, если номер телефона не содержит +7",
        TestName = "Присвоение неправильного номера телефона без +7")]
        public void TestNumberSet_ArgumentException(string wrongSurname, string message)
        {
            PhoneNumber phoneNumber = new PhoneNumber("+71234567891");
            Assert.Throws<ArgumentException>(() => { phoneNumber.Number = wrongSurname; }, message);
        }
        /// <summary>
        /// Позитывный тест cеттера Number
        /// </summary>
        [Test(Description = "Позитивный тест cеттера Number")]
        public void TestNumberSet_CorrectValue()
        {
            var expected = "+71234567891";
            PhoneNumber phoneNumber = new PhoneNumber(expected);
            phoneNumber.Number = expected;
            var actual = phoneNumber.Number;
            Assert.That(actual, Is.EqualTo(expected), "Позитивный тест сеттера ContactList");
        }
    }
}
