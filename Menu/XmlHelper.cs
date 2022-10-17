using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using static System.Reflection.Metadata.BlobBuilder;

namespace Menu
{
    internal class XmlHelper
    {
        private readonly static string _filePathMenu = @"../../../../Menu/Menu.xml";
        private readonly static string _rootAttributeMenu = "breakfast_menu";


        public static List<Food> LoadMenuItems()
        {
            var deserializer = new XmlSerializer(typeof(List<Food>), new XmlRootAttribute(_rootAttributeMenu));

            using (var reader = new StreamReader(_filePathMenu))
            {
                var menu = deserializer.Deserialize(reader);
                return (List<Food>)menu;
            }
        }

        public static void SaveMenuItems(List<Food> menu)
        {
            var serializer = new XmlSerializer(typeof(List<Food>), new XmlRootAttribute(_rootAttributeMenu));

            using (var fs = new FileStream(_filePathMenu, mode: FileMode.Create))
            {
                using (var writer = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, menu);

                }
            }
        }
    }
}
