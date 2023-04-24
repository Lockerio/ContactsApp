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
    public partial class ContactForm : Form
    {
        private Contact _contact = new Contact(
            "uhaiuh", 
            "dfona@gmail.com", 
            "+79516201136", 
            DateTime.Now, 
            "Locker"
        );

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

        private bool AreThereWrongFields(List<string> errorTexts)
        {
            foreach (string errorText in errorTexts)
            {
                if (errorText != "")
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckFormOnErrors()
        {
            List<string> errorTexts = new List<string>
            {
                _fullnameError,
                _emailError,
                _phonenumberError,
                _dateOfBirthError,
                _vkIdError,
            };

            if (AreThereWrongFields(errorTexts))
            {
                return true;
            }
            else
            {
                string message = string.Join("\n*", errorTexts);

                MessageBox.Show(
                    message,
                    "Ошибка!",
                    MessageBoxButtons.OKCancel,
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
                FullNameLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                FullNameLabel.BackColor = Color.LightPink;
                _fullnameError = ex.Message;
            }
            
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _emailError = "";
                _contact.Email = EmailTextBox.Text;
                EmailLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                EmailLabel.BackColor = Color.LightPink;
                _emailError = ex.Message;
            }
        }
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _phonenumberError = "";
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                PhoneNumberLabel.BackColor = Color.LightPink;
                _phonenumberError = ex.Message;
            }
        }
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _dateOfBirthError = "";
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                DateOfBirthLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                DateOfBirthLabel.BackColor = Color.LightPink;
                _dateOfBirthError = ex.Message;
            }
        }
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _vkIdError = "";
                _contact.VkId = VKTextBox.Text;
                VKLabel.BackColor = Color.White;
            }
            catch (ArgumentException ex)
            {
                VKLabel.BackColor = Color.LightPink;
                _vkIdError = ex.Message;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateContact();
        }
    }
}
