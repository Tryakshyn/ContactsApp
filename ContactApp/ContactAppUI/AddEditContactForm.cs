using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactApp
{
    public partial class AddEditContactForm : Form
    {
        public bool flag = false;
        Contact _contacts;
        public Contact Contacts
        {
            get 
            { 
                return _contacts; 
            }
            set 
            { 
                _contacts = value; 
            }
        }
        public AddEditContactForm()
        {
            InitializeComponent();
        }

        private void ButtonAddOk_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstnameBox.Text;
                string lastname = lastnameBox.Text;
                string phone = phoneBox.Text;
                string email = emailBox.Text;
                string vkid = vkidBox.Text;
                DateTime birthday = birthdayTimePicker.Value;
                if (Contacts == null)
                {
                    Contacts = new Contact(firstname, lastname, phone, email, birthday, vkid);
                }
                else
                {
                    Contacts.FirstName = firstname;
                    Contacts.LastName = lastname;
                    Contacts.Phone = phone;
                    Contacts.Email = email;
                    Contacts.Birthday = birthday;
                    Contacts.VkId = vkid;                               
                }
                flag = true;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ButtonAddCancel_Click(object sender, EventArgs e)
        {
            flag = false;
            Close();
        }

        private void AddEditContactForm_Shown(object sender, EventArgs e)
        {
            if (Contacts != null)
            {
                firstnameBox.Text = Contacts.FirstName;
                lastnameBox.Text = Contacts.LastName;
                phoneBox.Text = Contacts.Phone;
                emailBox.Text = Contacts.Email;
                birthdayTimePicker.Value = Contacts.Birthday;
                vkidBox.Text = Contacts.VkId;
            }
        }
    }
}
