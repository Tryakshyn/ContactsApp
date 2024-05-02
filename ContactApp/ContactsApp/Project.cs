using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий количество контактов, созданных в приложении
    /// </summary>
    public class Project
    {
        public List<Contact> сontactList;
        public Project()
        {
            сontactList = new List<Contact>();
        }
    }
}
