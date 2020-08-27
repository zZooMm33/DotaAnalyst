using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Xml;
using DotaAnalyst.Models;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class HeroXML : IHeroDAO
    {
        public List<Hero> GetHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            XmlDocument doc = new XmlDocument();
            doc.Load(ConfigurationManager.AppSettings[AppConfigConst.RESOURCES_PATH]);

            foreach (XmlNode node in doc.DocumentElement)
            {
                int id = int.Parse(node["id"].InnerText);
                string name = node["name"].InnerText;
                heroes.Add(new Hero() { Id = id, Name = name});
            }

            return heroes;
        }
    }
}
