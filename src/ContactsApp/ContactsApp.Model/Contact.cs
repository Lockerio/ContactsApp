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
    public class Contact : ICloneable
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
                var truncated = TruncateString(value, 100, nameof(FullName));
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
            set { _email = TruncateString(value, 100, nameof(Email)); }
        }

        /// <summary>
        /// Возвращает или задает телефонный номер
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = NormalizePhoneNumber(value, nameof(PhoneNumber)); }
        }

        /// <summary>
        /// Возвращает или задает дату рождения
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = ValidateDateOfBirth(value, nameof(DateOfBirth)); }
        }

        /// <summary>
        /// Возвращает или задает id ВКонтакте
        /// </summary>
        public string VkId
        {
            get { return _vkId; }
            set { _vkId = TruncateString(value, 50, nameof(VkId)); }
        }

        /// <summary>
        /// Ограничивает длину введенной строки
        /// </summary>
        /// <param name="value">Введенная строка</param>
        /// <param name="maxLength">Максимальная длина</param>
        /// <returns>Проверенную и отредактированную строку</returns>
        private string TruncateString(string value, int maxLength, string fieldName)
        {
            if (value == null)
            {
                return null;
            }
            else if (value.Length > maxLength)
            {
                string messege = fieldName + ": Вы превысили лимит в " + maxLength + " символов.";
                throw new ArgumentException(messege);
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
        private string NormalizePhoneNumber(string value, string fieldName)
        {
            List<char> digitChars = value.Where(char.IsDigit).ToList();
            int digitCharsCount = digitChars.Count;
            int amountOfCharsInNumber = 10;

            if (digitCharsCount >= 11 && digitCharsCount <= 14)
            {
                int startPosition = digitCharsCount - amountOfCharsInNumber;
                string countryCode;
                
                if (value[0] == '8')
                {
                    countryCode = "7";
                }
                else
                {
                    countryCode = string.Join("", digitChars.GetRange(0, startPosition));
                }

                List<char> number = digitChars.GetRange(startPosition, 10);

                string numberPart1 = 
                    string.Join("", digitChars.GetRange(0 + startPosition, 3));
                string numberPart2 = 
                    string.Join("", digitChars.GetRange(3 + startPosition, 3));
                string numberPart3 = 
                    string.Join("", digitChars.GetRange(6 + startPosition, 2));
                string numberPart4 = 
                    string.Join("", digitChars.GetRange(8 + startPosition, 2));

                string normalizedNumber = 
                    "+" + countryCode + " (" + numberPart1 + ") " + 
                    numberPart2 + "-" + numberPart3 + "-" + numberPart4 + " ";

                return normalizedNumber;
            }
            else
            {
                string messege = fieldName + ": Неверное количество цифр в телефонном номере.";
                throw new ArgumentException(messege);
            }
        }

        /// <summary>
        /// Проверяет введенную дату на актуальность
        /// </summary>
        /// <param name="value">Введенная дата</param>
        /// <returns>Проверенная дата</returns>
        /// <exception cref="ArgumentException">Дата должна быть поздее, чем 1900 год,
        /// и не должна быть в будущем</exception>
        private DateTime ValidateDateOfBirth(DateTime value, string fieldName)
        {
            if (value < new DateTime(1900, 1, 1))
            {
                string messege = fieldName + ": Дата рождения не может быть раньше, чем 1900 год.";
                throw new ArgumentException(messege);
            }
            else if (value > DateTime.Now)
            {
                string messege = fieldName + ": Дата рождения не может быть в будущем.";
                throw new ArgumentException(messege);
            }
            else
            {
                return value;
            }
        }

        public Object Clone()
        {
            return new Contact(FullName, Email, PhoneNumber, DateOfBirth, VkId);
        }
    }
}