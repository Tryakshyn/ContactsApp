using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Функция, выполняющая функцию сериализации
        /// </summary>
        public static void SaveFile(Project data)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter((@"C:\Users\Андрей\Desktop\ContactApp.txt")))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }
        /// <summary>
        /// Функция, выполняющая функцию десериализации
        /// </summary>
        public static Project LoadFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"C:\Users\Андрей\Desktop\ContactApp.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project)serializer.Deserialize<Project>(reader);
            }
        }
    }
}
