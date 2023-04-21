﻿using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        private Contact _contact = new Contact("uhaiuh", "dfona@gmail.com", "+7779898799", DateTime.Now, "Locker");

        private string _fullnameError;
        private string _emailError;
        private string _phonenumberError;
        private string _dateOfBirthError;
        private string _vkIdError;





        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkId;
        }

        private bool CheckFormOnErrors()
        {
            if (_fullnameError == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    _fullnameError,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
        

        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.VkId = VKTextBox.Text;
        }


        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }


        // AddPhotoButton
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {

        }
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _fullnameError = "";
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullnameError = ex.Message;
            }
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateContact();
        }
    }
}
