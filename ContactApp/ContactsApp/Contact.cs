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
        /// Номмер телефона
        /// </summary>
        private string phone;
        /// <summary>
        /// Электронная почта
        /// </summary>
        private string email;
        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime birthday;
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
                    throw new ArgumentException("Id VK не может быть длинее 15 символов");
                }
                vkId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя должно быть короче 50 символов");
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
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия должна быть короче 50 символов");
                }
                lastName = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
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
                email = value; 
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
                else if (birthday != value)
                {
                    birthday = value;
                }
            }
        }
        public Contact(string firstName, string lastName, string phone, string email, DateTime birthday, string vkId)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Birthday = birthday;
            VkId = vkId;
        }
        public Contact()
        {
        }
    }
}
