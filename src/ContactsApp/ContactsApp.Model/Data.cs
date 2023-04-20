using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Data
    {
        public List<string> fullnames = new List<string>
        {
            "Честер Беннингтон",
            "Серега Пират",
            "Курт Кобейн",
            "Аврил Лавин",
            "Олег Абрамов",
        };

        public List<string> emails = new List<string>
        {
            "InTheEnd@gmail.com",
            "pochemuTiEschoNeFanat@main.ru",
            "ligts_out@gmail.com",
            "sk8ter_boi@gmail.com",
            "ILoveSabaton@gmail.com",
        };

        public List<string> phoneNumbers = new List<string>
        {
            "+7(567)016-97-71",
            "+7(400)818-92-19",
            "+7(149)912-56-83",
            "+7(955)307-70-71",
            "+7(991)746-70-59",
        };

        public List<DateTime> datesOfBirth = new List<DateTime>
        {
            new DateTime(1976, 3, 20),
            new DateTime(1998, 4, 21),
            new DateTime(1967, 12, 20),
            new DateTime(1984, 9, 27),
            new DateTime(1989, 12, 15),
        };

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
