using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает главную форму
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса Project
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Обнавление списка контактов на форме 
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();

            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Добавление контакта в список _project.Contacts
        /// </summary>
        private void AddContact()
        {
            // Если нужно заполнить список рандомными данными 
            //Data data = new Data();
            //Contact contact = data.CreateContact();


            ContactForm contactForm = new ContactForm();
            DialogResult result = contactForm.ShowDialog();

            Contact contact = contactForm.Contact;

            if (result == DialogResult.OK)
            {
                _project.Contacts.Add(contact);
                UpdateListBox();
            }
            else if (result == DialogResult.Cancel) { }
        }

        /// <summary>
        /// Реактирование выбранного контакта
        /// </summary>
        /// <param name="index">Индекс выбранного контакта</param>
        private void EditObject(int index)
        {
            ContactForm contactForm = new ContactForm();
            Contact contact = _project.Contacts[index].Clone() as Contact;
            contactForm.Contact = contact;
            contactForm.UpdateForm();

            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _project.Contacts[index] = contactForm.Contact;
                UpdateListBox();
                UpdateSelectedContact(index);
            }
            else if (result == DialogResult.Cancel) { }
        }

        /// <summary>
        /// Удаление контакта из _project.Contacts
        /// </summary>
        /// <param name="index">Индекс текущего контакта</param>
        private void RemoveContact(int index)
        {
            if (index == -1) 
            {
                return;
            }

            var contact = _project.Contacts[index];
            DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить " + contact.FullName + " ?",
                "Подтверждение!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                _project.Contacts.Remove(contact);
                UpdateListBox();
            }
            else if (result == DialogResult.Cancel) { }
        }

        /// <summary>
        /// Отображение всей информации о выбранном контакте
        /// </summary>
        /// <param name="index">Индекс текущего контакта</param>
        private void UpdateSelectedContact(int index)
        {
            var contact = _project.Contacts[index];

            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            DateOfBirthTextBox.Text = contact.DateOfBirth.ToString();
            VKTextBox.Text = contact.VkId;
        }

        /// <summary>
        /// Очищение текстбоксов от информации выбранного контакта
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = null;
            EmailTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            DateOfBirthTextBox.Text = null;
            VKTextBox.Text = null;
        }

        /// <summary>
        /// Обработчик события выбора элемента в ListBox контактов
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void ContactsListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index == -1)
            {
                ClearSelectedContact();
            }
            else
            {
                UpdateSelectedContact(index);
            }
        }


        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Обработка события загрузки формы
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        /// <summary>
        /// Обработка события нажатия клавиш на форме
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Обработка события закрытия формы
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Вы уверены, что хотите закрыть форму?",
                    "Предупреждение!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        // AddContactButton
        /// <summary>
        /// Обработка события нажатия на кнопку "Добавить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            ClearSelectedContact();
            AddContact();
            UpdateListBox();
        }
        /// <summary>
        /// Обработка события наведения курсора на кнопку "Добавить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        /// <summary>
        /// Обработка события смещения курсора с кнопки "Добавить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }


        // EditContactButton
        /// <summary>
        /// Обработка события нажатия на кнопку "Редактировать контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            int contactIndex = ContactsListBox.SelectedIndex;
            if (contactIndex != -1)
            {
                EditObject(contactIndex);
                UpdateListBox();
            }
        }
        /// <summary>
        /// Обработка события наведения курсора на кнопку "Редактировать контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        /// <summary>
        /// Обработка события смещения курсора с кнопки "Редактировать контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }


        // RemoveContactButton
        /// <summary>
        /// Обработка события нажатия на кнопку "Удалить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
            ClearSelectedContact();
        }
        /// <summary>
        /// Обработка события наведения курсора на кнопку "Удалить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }
        /// <summary>
        /// Обработка события смещения курсора с кнопки "Удалить контакт"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }


        /// <summary>
        /// Обработка события нажатия на кнопку "Закрыть понель с именинниками"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Hide();
        }


        // ReadOnly Textboxes
        /// <summary>
        /// Обработка события ввода символов в текстбокс "FullNameTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// Обработка события ввода символов в текстбокс "EmailTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// Обработка события ввода символов в текстбокс "PhoneNumberTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// Обработка события ввода символов в текстбокс "DateOfBirthTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        /// <summary>
        /// Обработка события ввода символов в текстбокс "VKTextBox"
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}