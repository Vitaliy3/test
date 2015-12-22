using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static string fileName = "in.xml";
        static List<string> authors = new List<string>();

        static void Main(string[] args)
        {
            readAllAuthors();
            generateXML();
            Console.ReadKey();
        }

        //Выберем всех авторов и выведем на консоль
        static void readAllAuthors()
        {
            Console.WriteLine("Authors:");
            using (var reader = XmlReader.Create(fileName))
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "author")
                    {
                        reader.Read();
                        authors.Add(reader.Value);
                        Console.WriteLine(reader.Value);
                    }
                }
        }

        //выведем авторов в новый xml с разделенными именами и фамилиями
        static void generateXML()
        {

            XDocument doc = new XDocument();
            XElement all = new XElement("Authors");
            foreach (string auth in authors)
            {
                XElement record = new XElement("Author");
                XElement lastName = new XElement("lastName", auth.Substring(0, auth.IndexOf(',')));
                XElement firstName = new XElement("firstName", auth.Substring(auth.IndexOf(',')+2));
                record.Add(lastName);
                record.Add(firstName);
                all.Add(record);
            }
            doc.Add(all);
            doc.Save("out.xml");
        }
    }
}
