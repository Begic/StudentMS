using StudentMS.Models;
using System.Xml.Serialization;

namespace StudentMS.IO
{
    public class CsvToXmlConverter
    {
        public void Convert(List<Student> results)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            string filePath = @"C:\Users\begic\Desktop\student.xml";

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, results);
            }
        }
    }
}