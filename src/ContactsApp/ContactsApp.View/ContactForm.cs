using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает форму реедактирования контакта
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Экземпляр класса Contact
        /// </summary>
        private Contact _contact = new Contact(
            "Горюнов Аркадий", 
            "goryunov.arkadiy@gmail.com", 
            "89516201136", 
            DateTime.Now, 
            "Lockerio"
        );

        /// <summary>
        /// Текст ошибки поля fullname 
        /// </summary>
        private string _fullnameError;
        /// <summary>
        /// Текст ошибки поля email 
        /// </summary>
        private string _emailError;
        /// <summary>
        /// Текст ошибки поля phoneNumber 
        /// </summary>
        private string _phoneNumberError;
        /// <summary>
        /// Текст ошибки поля dateOfBirth 
        /// </summary>
        private string _dateOfBirthError;
        /// <summary>
        /// Текст ошибки поля vkId 
        /// </summary>
        private string _vkIdError;

        /// <summary>
        /// Обновляет данные на форме
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Находит поля в которых есть ошибки
        /// </summary>
        /// <param name="errorTexts">Массив описания ошибок</param>
        /// <returns>Индексы неправильных полей</returns>
        private List<int> GetWrongFields(List<string> errorTexts)
        {
            List<int> wrongFields = new List<int>();

            for (int i = 0; i < errorTexts.Count; i++)
            {
                if (errorTexts[i] != "")
                {
                    wrongFields.Add(i);
                }
            }
            return wrongFields;
        }

        /// <summary>
        /// Проверяет поля формы на ошибки
        /// </summary>
        /// <returns>True - ошибки есть, False - ошибок нет</returns>
        private bool DoesFormHaveErrors()
        {
            List<string> errorTexts = new List<string>
            {
                _fullnameError,
                _emailError,
                _phoneNumberError,
                _dateOfBirthError,
                _vkIdError,
            };

            List<int> wrongFields = GetWrongFields(errorTexts);
            
            if (wrongFields.Count == 0)
            {
                return false;
            }
            else
            {
                string message = "У вас возникли следующие ошибки:\n\n";
                var request = wrongFields.Select(wrongField => $"* {errorTexts[wrongField]}");
                message += string.Join("\n\n", request);

                MessageBox.Show(
                    message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
        }
        
        /// <summary>
        /// Обновляет данные контакта
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.VkId = VKTextBox.Text;
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }


        /// <summary>
        /// Обработка события нажатия на кнопку "OK"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!DoesFormHaveErrors())
            {
                UpdateContact();
            }
        }
        /// <summary>
        /// Обработка события нажатия на кнопку "Cancel"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // AddPhotoButton
        /// <summary>
        /// Обработка события нажатия на кнопку "Добавить фото"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Обработка события наведения курсора на кнопку "Добавить фото"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        /// <summary>
        /// Обработка события смещения курсора с кнопки "Добавить фото"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }


        /// <summary>
        /// Обработка события изменения текста в "FullNameTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _fullnameError = "";
                _contact.FullName = FullNameTextBox.Text;
                FullNamePictureBox.Visible = false;
            }
            catch (ArgumentException exception)
            {
                FullNamePictureBox.Visible = true;
                _fullnameError = exception.Message;
            }
            
        }
        /// <summary>
        /// Обработка события изменения текста в "EmailTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _emailError = "";
                _contact.Email = EmailTextBox.Text;
                EmailPictureBox.Visible = false;
            }
            catch (ArgumentException exception)
            {
                EmailPictureBox.Visible = true;
                _emailError = exception.Message;
            }
        }
        /// <summary>
        /// Обработка события изменения текста в "PhoneNumberTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _phoneNumberError = "";
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberPictureBox.Visible = false;
            }
            catch (ArgumentException exception)
            {
                PhoneNumberPictureBox.Visible = true;
                _phoneNumberError = exception.Message;
            }
        }
        /// <summary>
        /// Обработка события изменения значения в "DateOfBirthTimePicker"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _dateOfBirthError = "";
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                DateOfBirthPictureBox.Visible = false;
            }
            catch (ArgumentException exception)
            {
                DateOfBirthPictureBox.Visible = true;
                _dateOfBirthError = exception.Message;
            }
        }
        /// <summary>
        /// Обработка события изменения текста в "VKTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _vkIdError = "";
                _contact.VkId = VKTextBox.Text;
                VKPictureBox.Visible = false;
            }
            catch (ArgumentException exception)
            {
                VKPictureBox.Visible = true;
                _vkIdError = exception.Message;
            }
        }
    }
}