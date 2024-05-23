using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс,описывающий контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Идентификатор контакта в соц. сети VK
        /// </summary>
        private string vkId;
        /// <summary>
        /// Имя
        /// </summary>
        private string firstName;
        /// <summary>
        /// Фамилия
        /// </summary>
        private string lastName;
        /// <summary>
        /// Обьект класса номер телефона
        /// </summary>
        private PhoneNumber phonenumber;
        /// <summary>
        /// Электронная почта
        /// </summary>
        private string email;
        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime birthday;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Поле имя не может быть пустым");
                }
                if (value.Length > 50)
                {
                    var name = nameof(FirstName);
                    throw new ArgumentException($"Длина {name} равна {value.Length}, " + $"а должно быть меньше 50.", name);
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {

                return lastName;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Поле фамилия не может быть пустым");
                }
                if (value.Length > 50)
                {
                    var name = nameof(LastName);
                    throw new ArgumentException($"Длина {name} равна {value.Length}, " + $"а должно быть меньше 50.", name);
                }
                lastName = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Некорректная дата рождения! Год не может быть ранее, чем 1900 год");
                }
                birthday = value;
            }
        }
        public PhoneNumber phoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }

        public string Email
        {
            get 
            { 
                return email; 
            }
            set 
            {
                if (value.Length > 50)
                {
                    var name = nameof(LastName);
                    throw new ArgumentException($"Длина {name} равна {value.Length}, " + $"а должно быть меньше 50.", name);
                }
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Поле электронной почты должно содержать символ @");
                }
                email = value;
            }
        }
        public string VkId
        {
            get
            {
                return vkId;
            }
            set
            {
                if (value.Length > 15)
                {
                    var name = nameof(LastName);
                    throw new ArgumentException($"Длина {name} равна {value.Length}, " + $"а должно быть меньше 15.", name);
                }
                vkId = value;
            }
        }
        public Contact(string firstName, string lastName, DateTime birthday, PhoneNumber phonenumber, string email, string vkId)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            phoneNumber = phonenumber;
            Email = email;
            VkId = vkId;
        }
        public Contact()
        {
        }
    }
}
