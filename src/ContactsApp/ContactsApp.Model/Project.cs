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
        public List<Contact> SortContactsByName(List<Contact> contacts)
        {
            return contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Находит контакт по подстроке
        /// </summary>
        /// <param name="substring">Введенная подстрока</param>
        /// <returns>Список контактов, имя которых содержит введенную подстроку</returns>
        public List<Contact> FindContactsBySubstring(List<Contact> contacts, string substring)
        {   
            if (string.IsNullOrEmpty(substring))
            {
                return contacts;
            }
            substring = substring.ToLower();
            return contacts.Where(contact => contact.FullName.ToLower().
                            Contains(substring)).
                            ToList();
        }
    }
}
