using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает тестовые данные
    /// </summary>
    public class ContactsFactory
    {
        /// <summary>
        /// Список имен
        /// </summary>
        private List<string> fullnames = new List<string>
        {
            "Честер Беннингтон",
            "Серега Пират",
            "Курт Кобейн",
            "Аврил Лавин",
            "Олег Абрамов",
        };

        /// <summary>
        /// Список электроонных ящиков
        /// </summary>
        private List<string> emails = new List<string>
        {
            "InTheEnd@gmail.com",
            "pochemuTiEschoNeFanat@main.ru",
            "ligts_out@gmail.com",
            "sk8ter_boi@gmail.com",
            "ILoveSabaton@gmail.com",
        };

        /// <summary>
        /// Список Телефонных номеров
        /// </summary>
        private List<string> phoneNumbers = new List<string>
        {
            "+7(567)016-97-71",
            "+7(400)818-92-19",
            "+7(149)912-56-83",
            "+7(955)307-70-71",
            "+7(991)746-70-59",
        };

        /// <summary>
        /// Список дат рождения
        /// </summary>
        private List<DateTime> datesOfBirth = new List<DateTime>
        {
            new DateTime(1976, 3, 20),
            new DateTime(1998, 4, 21),
            new DateTime(1967, 12, 20),
            new DateTime(1984, 9, 27),
            new DateTime(1989, 12, 15),
        };

        /// <summary>
        /// Список id ВКонтакте
        /// </summary>
        private List<string> vkIds = new List<string>
        {
            "breakingTheHabitTonight",
            "serega_pirat",
            "NirvanaEnjoyer",
            "hateUrGF",
            "radiotapok",
        };

        public Contact CreateContact()
        {
            Random rand = new Random();

            Contact contact = new Contact(
                fullnames[rand.Next(fullnames.Count)],
                emails[rand.Next(emails.Count)],
                phoneNumbers[rand.Next(phoneNumbers.Count)],
                datesOfBirth[rand.Next(datesOfBirth.Count)],
                vkIds[rand.Next(vkIds.Count)]
            );
            return contact;
        }
    }
}
