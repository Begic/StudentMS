using StudentMS.IO;
using StudentMS.Models;

namespace StudentMS.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = $"C:\\Users\\begic\\Desktop\\SchuelerListe.CSV";

            var csvLoader = new CsvLoader();
            var result = csvLoader.ReadFile(path);

            DisplayStundents(result);
        }

        private static void DisplayStundents(List<Student> students)
        {
            var countOfClasses = students.GroupBy(x=> x.SchoolClass).Count();
            Console.WriteLine("Anzahl der Klassen:" + countOfClasses + "\n");

            int allStudents = 0;
            foreach (var schoolclass in students.OrderBy(x=> x.SchoolClass).GroupBy(x => x.SchoolClass).ToList())
            {
                var countOfStudents = students.Count(x => x.SchoolClass == schoolclass.Key);
                allStudents += countOfStudents;
                Console.WriteLine("Klasse: " + schoolclass.Key + " hat " + countOfStudents + " Schüler");
            }
            Console.WriteLine();
            Console.WriteLine("Anzahl der Schüler:" + students.Count + "\n");
            Console.WriteLine("Durchschnitt Anzahl der Schüler pro Klasse: " + allStudents / countOfClasses);
            Console.Read();
        }
    }
}