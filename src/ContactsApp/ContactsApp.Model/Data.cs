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
    public class Data
    {
        /// <summary>
        /// Список имен
        /// </summary>
        public List<string> fullnames = new List<string>
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
        public List<string> emails = new List<string>
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
        public List<string> phoneNumbers = new List<string>
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
        public List<DateTime> datesOfBirth = new List<DateTime>
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
        public List<string> vkIds = new List<string>
        {
            "breakingTheHabitTonight",
            "serega_pirat",
            "NirvanaEnjoyer",
            "hateUrGF",
            "radiotapok",
        };
    }
}
