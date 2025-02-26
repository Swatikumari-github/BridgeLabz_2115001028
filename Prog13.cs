

namespace json
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Xml;

    class Prog13
    {
        static void Main()
        {
            // JSON string
            string json = @"{
          ""name"": ""John Doe"",
          ""age"": 30,
          ""email"": ""john.doe@example.com"",
          ""address"": {
            ""city"": ""New York"",
            ""zip"": ""10001""
          }
        }";

            // Convert JSON to XML
            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json, "root");

            // Output the XML
            Console.WriteLine(xmlDoc.OuterXml);
        }
    }

}
