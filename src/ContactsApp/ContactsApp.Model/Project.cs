using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        private List<Contact> contacts;

        /// <summary>
        /// Конструктор класса Project, создает экземпляр этого класса
        /// </summary>
        public Project()
        {
            contacts = new List<Contact>();
        }

        /// <summary>
        /// Сортирует список по имени
        /// </summary>
        public void SortContactsByName()
        {
            contacts = contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Находит иименинников в списке
        /// </summary>
        /// <param name="date">Введеннай дата</param>
        /// <returns>Контакты, у которых день рождения совпадает с введенной датой</returns>
        public List<Contact> FindBirthdayContacts(DateTime date)
        {
            return contacts.Where(contact => contact.DateOfBirth.Month == date.Month && contact.DateOfBirth.Day == date.Day).ToList();
        }

        /// <summary>
        /// Находит контакт по подстроке
        /// </summary>
        /// <param name="substring">Введенная подстрока</param>
        /// <returns>Список контактов, имя которых содержит введенную подстроку</returns>
        public List<Contact> FindContactsBySubstring(string substring)
        {
            return contacts.Where(contact => contact.FullName.Contains(substring)).ToList();
        }
    }
}
