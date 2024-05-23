using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий номер телефона
    /// </summary>
    public class PhoneNumber
    {
        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Поле номера телефона не может быть пустым");
                }
                if (value.Length != 12)
                {
                    throw new ArgumentException("Номер должен состоять из 12 цифр");
                }
                if (value[0] != '+' || value[1] != '7')
                {
                    throw new ArgumentException("Номер должен начинаться с +7");
                }
                number = value;
            }
        }
        public PhoneNumber(string number)
        {
            Number = number;
        }
    }
}
