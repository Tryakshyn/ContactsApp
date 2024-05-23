using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactApp;
using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactAppUI
{
    /// <summary>
    /// Основная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        public Project _contactsListProject;
        public Project ContactsListProject
        {
            get
            { 
                return _contactsListProject; 
            }
            set
            {
                _contactsListProject = value; 
            }
        }
        public MainForm()
        {
            InitializeComponent();
            ContactsListProject = ProjectManager.LoadFile(); 
            UpdateContactListBox();
        }
        void UpdateContactListBox(int defaultSelectedIndex = -1)
        {
            var contactNames = ContactsListProject.ContactList.ToArray();
            contactListBox.Items.Clear();
            for (int i = 0; i < contactNames.Length; i++)
            {
                contactListBox.Items.Add(contactNames[i].LastName + " " + contactNames[i].FirstName);
            }
            contactListBox.SelectedIndex = defaultSelectedIndex;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            addEditContactForm.ShowDialog();
            if (addEditContactForm.flag == true)
            {
                Contact contact = addEditContactForm.Contacts;
                ContactsListProject.ContactList.Add(contact);
                UpdateContactListBox(ContactsListProject.ContactList.ToArray().Length - 1);
                ProjectManager.SaveFile(ContactsListProject);
            }
        } 

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт, который хотите редактировать!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddEditContactForm addEditContactForm = new AddEditContactForm();
                Contact contact = ContactsListProject.ContactList[contactListBox.SelectedIndex];
                addEditContactForm.Contacts = contact;
                addEditContactForm.ShowDialog();
                if (addEditContactForm.flag == true)
                {
                    UpdateContactListBox(contactListBox.SelectedIndex);
                    ProjectManager.SaveFile(ContactsListProject);
                }
            }
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт, который хотите удалить!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ContactsListProject.ContactList.Remove(ContactsListProject.ContactList[contactListBox.SelectedIndex]);
                UpdateContactListBox(ContactsListProject.ContactList.ToArray().Length - 1);
                ProjectManager.SaveFile(ContactsListProject);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            addEditContactForm.ShowDialog();
            if (addEditContactForm.flag == true)
            {
                Contact contact = addEditContactForm.Contacts;
                ContactsListProject.ContactList.Add(contact);
                UpdateContactListBox(ContactsListProject.ContactList.ToArray().Length - 1);
                ProjectManager.SaveFile(ContactsListProject);
            }
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт, который хотите редактировать!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddEditContactForm addEditContactForm = new AddEditContactForm();
                Contact contact = ContactsListProject.ContactList[contactListBox.SelectedIndex];
                addEditContactForm.Contacts = contact;
                addEditContactForm.ShowDialog();
                if (addEditContactForm.flag == true)
                {
                    UpdateContactListBox(contactListBox.SelectedIndex);
                    ProjectManager.SaveFile(ContactsListProject);
                }
            }
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт, который хотите удалить!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ContactsListProject.ContactList.Remove(ContactsListProject.ContactList[contactListBox.SelectedIndex]);
                UpdateContactListBox(ContactsListProject.ContactList.ToArray().Length - 1);
                ProjectManager.SaveFile(ContactsListProject);
            }
        }

        private void contactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = ContactsListProject.ContactList[contactListBox.SelectedIndex];
            
            firstnameBox.Text = contact.FirstName;
            lastnameBox.Text = contact.LastName;
            emailBox.Text = contact.Email;
            vkidBox.Text = contact.VkId;
            birthdayTimePicker.Text = contact.Birthday.ToString("d");
            phoneBox.Text = contact.phoneNumber.Number.ToString();
        }
    }
}
