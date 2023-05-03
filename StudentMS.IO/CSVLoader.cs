using System.Xml;
using System.Xml.Serialization;
using StudentMS.Models;

namespace StudentMS.IO
{
    public class CsvLoader
    {
        public void ReadFile(string path)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            Student? sultingMessage = (Student)serializer.Deserialize(new XmlTextReader(path));


        }
    }
}