using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using static System.Reflection.Metadata.BlobBuilder;

namespace Notes
{
    internal class XmlHelper
    {
        private readonly static string _filePathNote = @"../../../../Notes/Note.xml";
        private readonly static string _rootAttributeNote = "note";

        public static Note LoadNote()
        {
            var deserializer = new XmlSerializer(typeof(Note), new XmlRootAttribute(_rootAttributeNote));

            using (var fileStream = new FileStream(_filePathNote, FileMode.Open))
            {
                var note = (Note)deserializer.Deserialize(fileStream);
                return note;
            };
        }

        public static void SaveNote(Note note)
        {
            var serializer = new XmlSerializer(typeof(Note));

            using (var fs = new FileStream(_filePathNote, mode: FileMode.Create))
            {
                using (var writer = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    serializer.Serialize(writer, note);

                }
            }
        }
    }
}
