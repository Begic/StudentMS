using System.Text;
using StudentMS.Models;

namespace StudentMS.IO
{
    public class CsvLoader
    {
        public List<Student> ReadFile(string path)
        {
            var csvLines = File.ReadLines(path, Encoding.UTF7).ToList();
            return ConvertLines(csvLines);
        }

        private List<Student> ConvertLines(List<string> csvLines)
        {
            var studens = new List<Student>();
            foreach (var csvLine in csvLines.Skip(1))
            {
                var splitetLine = csvLine.Split(';');

                studens.Add(new Student
                {
                    SchoolClass = splitetLine[0],
                    FirstName = splitetLine[1],
                    LastName = splitetLine[2],
                    Email = splitetLine[1] + splitetLine[2]+"@mail.at"
                });
            }

            return studens;
        }
    }
}