using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;
using NUnit.Framework;

namespace ContactsAppModel.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test(Description = "Позитивный тест сеттера FullName")]
        public void FullName_SetCorrectValue_SetSameValueTitle()
        {
            // Arrange
            var contact = new Contact();
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            string correctFullName = "ронни радке";
            string expected = textInfo.ToTitleCase(correctFullName);

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неправильное имя");
        }

        [Test(Description = "Отрицательный тест сеттера FullName")]
        public void FullName_SetArgumentException_ThrowException()
        {
            // Arrange
            var wrongSurname = "Roooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "ooooooooooooooooooooooooooooooooooooooooonny";
            var contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(
                () => { contact.FullName = wrongSurname; },
                "Должно возникать исключение, если фамилия длиннее 100 символов");
        }

        [Test(Description = "Позитивный тест геттера FullName")]
        public void FullName_GetCorrectValue_ReturnsSameValueTitle()
        {
            // Arrange
            var contact = new Contact();
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            string correctFullName = "ронни радке";
            string expected = textInfo.ToTitleCase(correctFullName);
            Console.WriteLine(expected);

            // Act
            contact.FullName = correctFullName;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неправильное имя");
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void Email_SetCorrectValue_SetSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctEmail = "FallingInReverse@gmail.com";
            string expected = correctEmail;

            // Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный мейл");
        }

        [Test(Description = "Отрицательный тест сеттера Email")]
        public void Email_SetArgumentException_ThrowException()
        {
            // Arrange
            var wrongEmail =
                "I_wake_up_every_morning_with_my_head_up_in_a_daze" +
                "I'm_not_sure_if_I_should_say_this,_fuck,_I'll_say_it_anyway" +
                "Everybody_tries_to_tell_me_that_I'm_going_through_a_phase" +
                "I_don't_know_if_it's_a_phase,_I_just_wanna_feel_okay@gmail.com";
            var contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(
                () => { contact.Email = wrongEmail; },
                "Должно возникать исключение, если мейл длиннее 100 символов");
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void Email_GetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctEmail = "FallingInReverse@gmail.com";
            string expected = correctEmail;

            // Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный мейл");
        }

        [Test(Description = "Позитивный тест сеттера PhoneNumber")]
        public void PhoneNumber_SetCorrectValue_SetSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctPhoneNumber = "89516201136";
            string expected = "+7 (951) 620-11-36";

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неправильный номер");
        }

        [Description("Отрицательный тест сеттера PhoneNumber")]
        [TestCase("", "Должно возникать исключение, если в номере меньше 11 цифр",
            TestName = "Присвоение строки, в которой меньше 11 цифр, в качестве номера")]
        [TestCase("789789789789781525628925624562563245621562", 
            "Должно возникать исключение, если цифр в номере больше, чем 14",
            TestName = "Присвоение строки, в которой больше 14 цифр, в качестве номера")]
        public void PhoneNumber_SetArgumentException_ThrowException(string wrongPhoneNumber, string message)
        {
            // Arrange
            var contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(
                () => { contact.PhoneNumber = wrongPhoneNumber; },
                message);
        }

        [Test(Description = "Позитивный тест геттера PhoneNumber")]
        public void PhoneNumber_GetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctPhoneNumber = "89516201136";
            string expected = "+7 (951) 620-11-36";

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неправильный номер");
        }
        
        [Test(Description = "Позитивный тест сеттера DateOfBirth")]
        public void DateOfBirth_SetCorrectValue_SetSameValue()
        {
            // Arrange
            var contact = new Contact();
            DateTime correctDateOfBirth = new DateTime(1983, 12, 15);
            DateTime expected = new DateTime(1983, 12, 15);

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfBirth возвращает неправильную дату");
        }

        [Description("Отрицательный тест сеттера DateOfBirth")]
        [TestCase("1800-01-01", "Должно возникать исключение, если дата раньше, чем 1 января 1900 года",
            TestName = "Присвоение даты, которая была раньше, чем 1 января 1900 года")]
        [TestCase("2222-01-01",
            "Должно возникать исключение, если дата в будущем",
            TestName = "Присвоение даты в будущем")]
        public void DateOfBirth_SetArgumentException_ThrowException(DateTime wrongDateOfBirth, string message)
        {
            // Arrange
            var contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(
                () => { contact.DateOfBirth = wrongDateOfBirth; },
                message);
        }

        [Test(Description = "Позитивный тест геттера DateOfBirth")]
        public void DateOfBirth_GetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            DateTime correctDateOfBirth = new DateTime(1983, 12, 15);
            DateTime expected = new DateTime(1983, 12, 15);

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfBirth возвращает неправильную дату");
        }

        [Test(Description = "Позитивный тест сеттера VkId")]
        public void VkId_SetCorrectValue_SetSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctVkId = "PopularMonster";
            string expected = correctVkId;

            // Act
            contact.VkId = correctVkId;
            var actual = contact.VkId;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер VkId возвращает неправильный вк id");
        }

        [Test(Description = "Отрицательный тест сеттера VkId")]
        public void VkId_SetArgumentException_ThrowException()
        {
            // Arrange
            var wrongVkId = "Energetic_musician_with_extraordinary_appearance" +
                "_and_strong_stage_presence";
            var contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(
                () => { contact.VkId = wrongVkId; },
                "Должно возникать исключение, если мейл длиннее 50 символов");
        }

        [Test(Description = "Позитивный тест геттера VkId")]
        public void VkId_GetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            string correctVkId = "PopularMonster";
            string expected = correctVkId;

            // Act
            contact.VkId = correctVkId;
            var actual = contact.VkId;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер VkId возвращает неправильный вк id");
        }    
    }
}