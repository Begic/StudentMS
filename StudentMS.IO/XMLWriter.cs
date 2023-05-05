using System.Xml.Serialization;

namespace StudentMS.IO
{
    public class XMLWriter
    {
        public static async Task WriteXML<T>(List<T> results, string path)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                await Task.Run(() => serializer.Serialize(stream, results));
            }
        }
    }
}