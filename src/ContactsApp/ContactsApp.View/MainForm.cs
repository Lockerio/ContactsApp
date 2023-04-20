using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();


        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();

            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        private void AddContact()
        {
            Data data = new Data();
            Random rand = new Random();
            int elementsAmount = 5;

            Contact contact = new Contact(
                data.fullnames[rand.Next(elementsAmount)],
                data.emails[rand.Next(elementsAmount)],
                data.phoneNumbers[rand.Next(elementsAmount)],
                data.datesOfBirth[rand.Next(elementsAmount)],
                data.vkIds[rand.Next(elementsAmount)]
            );

            _project.Contacts.Add(contact);
        }

        private void RemoveContact(int index)
        {
            _project.Contacts.RemoveAt(index);
            UpdateListBox();
        }




        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }


        // AddContactButton
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
            //var form = new ContactForm();
            //form.ShowDialog();
        }
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }


        // EditContactButton
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
        }
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }


        // RemoveContactButton
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }


        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Hide();
        }


        // ReadOnly Textboxes
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
