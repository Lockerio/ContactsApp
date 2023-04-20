using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Конструктор класса Project, создает экземпляр этого класса
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }

        /// <summary>
        /// Возвращает или задает список контактов
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = new List<Contact>();
            }
        }
        
        /// <summary>
        /// Сортирует список по имени
        /// </summary>
        public void SortContactsByName()
        {
            Contacts = Contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Находит именинников в списке
        /// </summary>
        /// <param name="date">Введеннай дата</param>
        /// <returns>Контакты, у которых день рождения совпадает с введенной датой</returns>
        public List<Contact> FindBirthdayContacts(DateTime date)
        {
            return Contacts.Where(contact => contact.DateOfBirth.Month == date.Month
            && contact.DateOfBirth.Day == date.Day).ToList();
        }

        /// <summary>
        /// Находит контакт по подстроке
        /// </summary>
        /// <param name="substring">Введенная подстрока</param>
        /// <returns>Список контактов, имя которых содержит введенную подстроку</returns>
        public List<Contact> FindContactsBySubstring(string substring)
        {
            return Contacts.Where(contact => contact.FullName.Contains(substring)).ToList();
        }
    }
}
