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
    public static class ProjectSerializer
    {
        private static string appDataFolder =
            Environment.GetFolderPath(SpecialFolder.ApplicationData);
        private static string developerSubdirectory = "Goryunov";
        private static string projectSubdirectory = "ContactsApp";
        private static string filename = "userdata.json";

        private static string _fullPath = Path.Combine(appDataFolder,
            developerSubdirectory, projectSubdirectory, filename);


        public static void SaveToFile(Project project)
        {
            string directoryPath = Path.GetDirectoryName(_fullPath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string json = JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(_fullPath, json);


        }

        public static Project LoadFromFile()
        {
            if (File.Exists(_fullPath))
            {
                string json = File.ReadAllText(_fullPath);
                return JsonConvert.DeserializeObject<Project>(json);
            }
            else
            {
                return new Project();
            }
        }
    }
}
