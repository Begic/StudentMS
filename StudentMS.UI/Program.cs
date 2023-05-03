using StudentMS.IO;
using StudentMS.Models;

namespace StudentMS.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = $"C:\\Users\\begic\\Desktop\\SchuelerListe.xml";

            var csvLoader = new CsvLoader();
             csvLoader.ReadFile(path);
        }
    }
}