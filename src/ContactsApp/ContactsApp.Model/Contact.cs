using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Электронная почта
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефонный номер
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Id ВКонтакте
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Конструктор класса Contact, создает экземпляр этого класса
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="phoneNumber">Телефонный номер</param>
        /// <param name="dateOfBirth">Дата рождения</param>
        /// <param name="vkId">id ВКонтакте</param>
        public Contact(
            string fullName, 
            string email, 
            string phoneNumber, 
            DateTime dateOfBirth, 
            string vkId)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            VkId = vkId;
        }

        /// <summary>
        /// Возвращает или задает полное имя
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set 
            {
                var truncated = TruncateString(value, 100);
                var textInfo = CultureInfo.CurrentCulture.TextInfo;
                _fullName = textInfo.ToTitleCase(truncated.ToLower());
            }
        }

        /// <summary>
        /// Возвращает или задает электронную почту
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = TruncateString(value, 100); }
        }

        /// <summary>
        /// Возвращает или задает телефонный номер
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = NormalizePhoneNumber(value); }
        }

        /// <summary>
        /// Возвращает или задает дату рождения
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = ValidateDateOfBirth(value); }
        }

        /// <summary>
        /// Возвращает или задает id ВКонтакте
        /// </summary>
        public string VkId
        {
            get { return _vkId; }
            set { _vkId = TruncateString(value, 50); }
        }

        /// <summary>
        /// Ограничивает длину введенной строки
        /// </summary>
        /// <param name="value">Введенная строка</param>
        /// <param name="maxLength">Максимальная длина</param>
        /// <returns>Проверенную и отредактированную строку</returns>
        private string TruncateString(string value, int maxLength)
        {
            if (value == null)
            {
                return null;
            }
            else if (value.Length > maxLength)
            {
                //return value.Substring(0, maxLength);
                throw new ArgumentException(
                    "Amount of symbols is too high, you can use only " + value + " symbols");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Проверяет телефонный номер на недопустимые символы и отсеивает их
        /// </summary>
        /// <param name="value">Введенный телефонный номер</param>
        /// <returns>Проверенный и отредактированный номер</returns>
        private string NormalizePhoneNumber(string value)
        {
            if (value == null)
            {
                return null;
            }

            string normalized = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c) || c == '+' || c == '(' || c == ')' || c == '-' || c == ' ')
                {
                    normalized += c;
                }
            }
            return normalized;
        }

        /// <summary>
        /// Проверяет введенную дату на актуальность
        /// </summary>
        /// <param name="value">Введенная дата</param>
        /// <returns>Проверенная дата</returns>
        /// <exception cref="ArgumentException">Дата должна быть поздее, чем 1900 год,
        /// и не должна быть в будущем</exception>
        private DateTime ValidateDateOfBirth(DateTime value)
        {
            if (value < new DateTime(1900, 1, 1))
            {
                throw new ArgumentException("Date of birth cannot be earlier than 1900.");
            }
            else if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }
            else
            {
                return value;
            }
        }
    }
}