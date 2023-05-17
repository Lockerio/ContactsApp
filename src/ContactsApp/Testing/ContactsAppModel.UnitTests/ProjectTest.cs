using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;
using System.Data.SqlTypes;

namespace ContactsAppModel.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test(Description = "Позитивный тест сеттера Contacts")]
        public void Contacts_SetCorrectValue_SetSameValue()
        {
            // Arrange
            var contacts = new List<Contact> { };
            contacts.Add(new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ));
            contacts.Add(new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ));
            contacts.Add(new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                ));

            var expected = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };

            // Act
            var actual = contacts;

            // Assert
            Assert.AreNotSame(expected, actual, "Геттер Contacts возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест геттера Contacts")]
        public void Contacts_GetCorrectValue_GetSameValue()
        {
            // Arrange
            var contacts = new List<Contact> { };
            contacts.Add(new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ));
            contacts.Add(new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ));
            contacts.Add(new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                ));

            var expected = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };

            // Act
            var actual = contacts;

            // Assert
            Assert.AreNotSame(expected, actual, "Геттер Contacts возвращает неправильное значение");
        }

        [Test(Description = "Тест сортировки Contacts по имени")]
        public void SortContactsByName_AlphabetSort_ReturnSortedList()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };
            var expected = new List<Contact>
            {
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                )
                
            };
            Project project = new Project();

            // Act
            var actual = project.SortContactsByName(contacts);

            // Assert
            Assert.AreNotSame(expected, actual, "Сортировка по имени не работает");
        }

        [Test(Description = "Тест фильтрации Contacts по строке")]
        public void FindContactsBySubstring_SearchBySubstring_ReturnFilteredList()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };
            var expected = new List<Contact>
            {
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };
            string substring = "Курт";
            Project project = new Project();

            // Act
            var actual = project.FindContactsBySubstring(contacts, substring);

            // Assert
            Assert.AreNotSame(expected, actual, "Фильтрация по строке не работает");
        }
        [Test(Description = "Тест фильтрации Contacts по пустой строке")]
        public void FindContactsByEmptySubstring_SearchBySubstring_ReturnFilteredList()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };
            var expected = new List<Contact>
            {
                new Contact(
                    "Честер Беннингтон",
                    "InTheEnd@gmail.com",
                    "+7(567)016-97-71",
                    new DateTime(1976, 3, 20),
                    "breakingTheHabitTonight"
                ),
                new Contact(
                    "Серега Пират",
                    "pochemuTiEschoNeFanat@main.ru",
                    "+7(400)818-92-19",
                    new DateTime(1998, 4, 21),
                    "serega_pirat"
                ),
                new Contact(
                    "Курт Кобейн",
                    "ligts_out@gmail.com",
                    "+7(149)912-56-83",
                    new DateTime(1967, 12, 20),
                    "NirvanaEnjoyer"
                )
            };
            string substring = "";
            Project project = new Project();

            // Act
            var actual = project.FindContactsBySubstring(contacts, substring);

            // Assert
            Assert.AreNotSame(expected, actual, "Фильтрация по строке не работает");
        }
    }
}
