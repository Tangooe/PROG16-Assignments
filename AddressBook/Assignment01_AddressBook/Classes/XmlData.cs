using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using AddressBook.Ojbects;
//FIX ORDER
namespace AddressBook.Classes
{
    public class XmlData
    {
        public static List<Contact> LoadData(List<Contact> contacts, string filepath)
        {
            try
            {
                var xmlDoc = XDocument.Load(filepath);
                var xElements = xmlDoc.Descendants("Contact");
                var xmlSerializer = new XmlSerializer(typeof(Contact));
                contacts = xElements.Select(xe => (Contact)xmlSerializer.Deserialize(xe.CreateReader())).ToList();
                contacts.RemoveAt(0);
            }
            catch (Exception)
            {
                CreateFile(filepath);
            }

            return contacts;
        }

        public static void SaveData(List<Contact> contacts,string filepath)
        {
            try
            {
                var xElement = new XElement("Contact",
                    from c in contacts
                    select new XElement("Contact",
                            new XElement("Name", c.Name),
                            new XElement("Address", c.Address),
                            new XElement("AreaCode", c.AreaCode),
                            new XElement("City", c.City),
                            new XElement("Phone", c.Phone),
                            new XElement("Email", c.Email)
                            ));
                xElement.Save(filepath);

                Properties.Settings.Default.Filepath = filepath;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void CreateFile(string filePath)
        {
            var folderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));

            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch(Exception)
                {
                    throw;
                }
            }

            else if (!File.Exists(filePath))
            {
                try
                {
                    File.Create(filePath);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}
