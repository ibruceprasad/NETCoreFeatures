using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice_.Net8.src._3.XML
{
    public record Person(string Name, int Age);
    public record PersonCollection(Person[] People);

    public class XMLReadWriteTest
    {


        [Fact]
        public void WriteXML_Test()
        {
            string rawXml = """
            <people>
                <person>
                    <name>John Doe</name>
                    <age>42</age>
                </person>
                <person>
                    <name>Jane Doe</name>
                    <age>39</age>
                </person>
            </people>
            """;
            var writeStatus = XMLReadWrite.WriteXML(rawXml);
            writeStatus.Should().Be(true);
        }



        [Fact]
        public void ReadXML_Test()
        {
            var readData = XMLReadWrite.ReadXML();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("people.xml");
            XmlNodeList? items = xmlDocument.SelectNodes("/people/person");
            var people = new List<Person>();
            foreach (XmlNode item in items)
            {
                var person = new Person(item["name"].InnerText, Convert.ToInt16(item["age"].InnerText));
                people.Add(person);
            }
            PersonCollection personCollection = new PersonCollection(people.ToArray());
            personCollection.People.Length.Should().Be(2);
        }
    }
}