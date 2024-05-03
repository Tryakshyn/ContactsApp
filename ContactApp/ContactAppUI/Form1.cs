using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using Newtonsoft.Json;

namespace ContactAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Project project = new Project();
            Contact contact = new Contact();
            contact.ContactId = 0;
            contact.LastName = "Tryakshin";
            contact.FirstName = "Andrey";
            contact.Phone = "89016070939";
            contact.Email = "andrey.tryakshin@mail.ru";
            project.сontactList.Add(contact);
            ProjectManager.SaveFile(project);
            ProjectManager.LoadFile();
        }
    }
}
