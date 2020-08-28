using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using DotaAnalyst.Models;

namespace DotaAnalyst.Utils
{
    public class CreateResources
    {
        public const string HEROES_FILE_NAME = @"/Heroes.xml";

        public static bool Create()
        {
            string path = Path.GetTempPath() + ConfigurationManager.AppSettings[AppConfigConst.RESOURCES_PATH_NAME];

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (!CreateHeroes(path)) throw new Exception("Не удалось создать файл с геройми.");
            if (!CreateHeroesRelations(path)) throw new Exception("Не удалось создать файл с аналитикой для героев.");
            if (!CreateItems(path)) throw new Exception("Не удалось создать файл с предметами.");

            return true;
        }

        private static bool CreateHeroes(string path)
        {
            if (!File.Exists(path + HEROES_FILE_NAME))
            {
                File.Create(path + HEROES_FILE_NAME).Close();

                List<Hero> heroes = new List<Hero>()
                {
                    new Hero() { Id = 1, Name = "Abaddon"},
                    new Hero() { Id = 2, Name = "Alchemist"},
                    new Hero() { Id = 3, Name = "Axe"},
                    new Hero() { Id = 4, Name = "Beastmaster"},
                    new Hero() { Id = 5, Name = "Bristleback"},
                    new Hero() { Id = 6, Name = "Centaur Warrunner"},
                    new Hero() { Id = 7, Name = "Chaos Knight"},
                    new Hero() { Id = 8, Name = "Clockwerk"},
                    new Hero() { Id = 9, Name = "Doom"},
                    new Hero() { Id = 10, Name = "Dragon Knight"},
                };

                XDocument xdoc = new XDocument();
                XElement xmlElements = new XElement("Heroes",
                    heroes.Select(
                        i => new XElement("hero", new XElement("id", i.Id), new XElement("name", i.Name))
                    ));
                xdoc.Add(xmlElements);
                xdoc.Save(path + HEROES_FILE_NAME);                
            }

            return true;
        }

        private static bool CreateHeroesRelations(string path)
        {
            return true;
        }

        private static bool CreateItems(string path)
        {
            return true;
        }
    }
}
