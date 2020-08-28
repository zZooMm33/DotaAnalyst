using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using DotaAnalyst.Models;
using DotaAnalyst.Utils;

namespace DotaAnalyst.Database
{
    public class HeroXML : IHeroDAO
    {
        public List<Hero> GetHeroes()
        {
            XDocument doc = XDocument.Load(Path.GetTempPath()
                + ConfigurationManager.AppSettings[AppConfigConst.RESOURCES_PATH_NAME]
                + CreateResources.HEROES_FILE_NAME);

            var heroes = doc.Descendants("hero").Select(item =>
                    new Hero()
                    {
                        Id = int.Parse(item.Element("id").Value),
                        Name = item.Element("name").Value
                    }).ToList();

            return heroes;
        }
    }
}
