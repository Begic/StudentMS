using System.Xml.Serialization;

namespace StudentMS.IO
{
    public class XMLReader
    {
        public static async Task<List<T>?> ReadXML<T>(string filePath)
        {
            await using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                return await Task.Run(() => (List<T>)serializer.Deserialize(stream));
            }
        }
    }
}