using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий количество контактов, созданных в приложении
    /// </summary>
    public class Project
    {
        private List<Contact> _сontactList;
        public List<Contact> ContactList
        {
            get 
            { 
                return _сontactList;
            }
            set 
            {
                _сontactList = value; 
            }
        }
        public Project(List<Contact> contactList)
        {
            ContactList = contactList;
        }
    }
}
