using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using static System.Environment;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает ProjectSerializer
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь до 'AppData'
        /// </summary>
        private static string appDataFolder =
            Environment.GetFolderPath(SpecialFolder.ApplicationData);

        /// <summary>
        /// Подпапка разработчика
        /// </summary>
        private static string developerSubdirectory = "Goryunov";

        /// <summary>
        /// Подпапка проекта разработчика
        /// </summary>
        private static string projectSubdirectory = "ContactsApp";

        /// <summary>
        /// Имя файла
        /// </summary>
        private static string filename = "userdata.json";

        /// <summary>
        /// Полный путь до файла с сохраненными данными
        /// </summary>
        private static string _fullPath = Path.Combine(appDataFolder,
            developerSubdirectory, projectSubdirectory, filename);

        /// <summary>
        /// Возвращает или задает путь до файла с сохраненными данными
        /// </summary>
        public static string Filename 
        { 
            get { return _fullPath; } 
            set { _fullPath = value; }
        }

        /// <summary>
        /// Сохраняет текущие данные о контактах в файл
        /// </summary>
        /// <param name="project">Список контактов</param>
        public static void SaveToFile(Project project)
        {
            string directoryPath = Path.GetDirectoryName(Filename);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string json = JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Filename, json);


        }

        /// <summary>
        /// Загружает список контактов из файла 
        /// </summary>
        /// <returns>Список контактов</returns>
        public static Project LoadFromFile()
        {
            if (File.Exists(Filename))
            {
                string json = File.ReadAllText(Filename);
                return JsonConvert.DeserializeObject<Project>(json);
            }
            else
            {
                return new Project();
            }
        }
    }
}
