using System;
using System.IO;
using System.Xml.Linq;

namespace DotaAnalyst.Utils
{
    public class CreateResources
    {
        public static bool Create(string path)
        {

            if (!CreateHeroes(path)) throw new Exception("Не удалось создать файл с геройми.");
            if (!CreateHeroesRelations(path)) throw new Exception("Не удалось создать файл с аналитикой для героев.");
            if (!CreateItems(path)) throw new Exception("Не удалось создать файл с предметами.");


            return true;
        }

        private static bool CreateHeroes(string path)
        {
            if (!File.Exists(path + "Heroes.xml"))
            {
                //File.Create("textboxFile.txt").Close();

                //XDocument xdoc = new XDocument();
                //// создаем первый элемент
                //XElement iphone6 = new XElement("phone");
                //// создаем атрибут
                //XAttribute iphoneNameAttr = new XAttribute("name", "iPhone 6");
                //XElement iphoneCompanyElem = new XElement("company", "Apple");
                //XElement iphonePriceElem = new XElement("price", "40000");
                //// добавляем атрибут и элементы в первый элемент
                //iphone6.Add(iphoneNameAttr);
                //iphone6.Add(iphoneCompanyElem);
                //iphone6.Add(iphonePriceElem);

                //// создаем второй элемент
                //XElement galaxys5 = new XElement("phone");
                //XAttribute galaxysNameAttr = new XAttribute("name", "Samsung Galaxy S5");
                //XElement galaxysCompanyElem = new XElement("company", "Samsung");
                //XElement galaxysPriceElem = new XElement("price", "33000");
                //galaxys5.Add(galaxysNameAttr);
                //galaxys5.Add(galaxysCompanyElem);
                //galaxys5.Add(galaxysPriceElem);
                //// создаем корневой элемент
                //XElement phones = new XElement("phones");
                //// добавляем в корневой элемент
                //phones.Add(iphone6);
                //phones.Add(galaxys5);
                //// добавляем корневой элемент в документ
                //xdoc.Add(phones);
                ////сохраняем документ
                //xdoc.Save("phones.xml");

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
